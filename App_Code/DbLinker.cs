using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// Summary description for DbLinker  // הלינקר עושה את כל האס קיו אל בדתאבייס
/// </summary>
public class DbLinker
{
    private string connectionString; // הכתובת של הבסיס נתונים
    private string commandString;  //  פקודת השיאלתא שאנו רוצים להריץ
    private OleDbConnection dbConn;  //  משתנה קישור למאגר נתונים - מבצע את הקישור עצמו
    private OleDbCommand dbComm;  //  משתנה שמפעיל את פעולת השאילתא בבסיס נתונים
    private OleDbDataAdapter reader;  //  אובייקט שקורא את הטבלה שנוצרת בעקבות הפעלת הסלקט, אדפטר - משכפל את תוצאת השאילתא
    private DataSet ds;  //  תוצאת השכפול של טבלת התשובה מהשאילתא - וירטואלי
    private DataTable dt;   //  תוצאת הטבלה בשרת במאגר הנתונים - לא וירטואלית
    private int rowsAffected;  //  כמות השורות ששונו בעקבות שאילתות מעדכנות
    private List<User> users;  //  רשימת המידע שיש בטבלה - המשתמשים

    public DbLinker()
    {
        connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= |DataDirectory|\Database1.accdb; Persist Security Info = True";
        dbConn = new OleDbConnection(connectionString);
    }

    private void Open()  // פתיחת קישור
    {
        dbConn.Open();  // מבצע פתיחת קישור
    }

    private void Close()   // מבצע סגירת קישור
    {
        dbConn.Close();
    }

    // כל הפעולות הן פרייבט - פעולות שירות כדי שלא יהיה גישה למשתמש מבחוץ , הגישה היא גישה פנימית לתוך הלינקר

    private void Querry()  // מבצע שאילתת סלקט לא מעדכנת
    {
        dbComm = new OleDbCommand(commandString, dbConn); 
        reader = new OleDbDataAdapter(dbComm);
        ds = new DataSet();
        reader.Fill(ds, "client");  //  הפעולה מקבלת תשובה לשאילתא 
    }

    private void NonQuerry()  //  פעולות עדכון כמו מחיקה, הוספה, עדכון
    {
        dbComm = new OleDbCommand(commandString, dbConn);  //  כאן מגדירים את הפעולה
        Open();
        rowsAffected=dbComm.ExecuteNonQuery();
        Close();
    }

    private User ConvertRow()  //  מייצר את רשימת המשתמשים מתוך התשובה שקיבלנו בסלקט - שאילתת אס קיו אל
    {
        User temp = new User();  // לוקח את כל הנתונים שיש בעמודות שיהיו חלק מהאובייקט
        if (dt.Rows.Count == 1)
        {
            DataRow row = dt.Rows[0];
            string name = (string)(row["UserName"]);
            string password = (string)(row["Pass1"]);
            string mail = (string)(row["Mail"]);
            string phone = (string)(row["Phone"]);
            string snif = (string)(row["Snif"]);
            int level = (int)(row["Level"]);
            temp = new User(name, password, mail, phone, snif, level);
        }
        return temp;
    }

    private void ConvertList()  //  אותה פעולה כמו קונברט רואו - רק שהיא מחזירה רשימת משתמשים
    {
        User temp = new User();
        users = new List<User>();
        for (int count=0;count< dt.Rows.Count;count++)
        {
            DataRow row = dt.Rows[count];
            string name = (string)(row["UserName"]);
            string password = (string)(row["Pass1"]);
            string mail = (string)(row["Mail"]);
            string phone = (string)(row["Phone"]);
            string snif = (string)(row["Snif"]);
            int level = (int)(row["Level"]);
            temp = new User(name, password, mail, phone, snif, level);
            users.Add(temp);
        }
    }

    // שאילתות פבליק - מאפשר לאתר להרי בדתאבייס

    public User IsExist(string username)  //  שאילתא הבודקת אם המשתמש קיים במאגר הנתונים
    {
        commandString = string.Format("Select * from [client] where [UserName]='{0}'", username );  //  שאילתא - כל פנייה למאגר הנתונים נקראת שאילתא
        Querry();
        dt = ds.Tables[0];
        if (dt.Rows.Count == 0)
            return new User();
        else
            return ConvertRow();
    }

    public User IsExist(string username,string password)  //  פעולה להזדהות - בודקת אם קיים משתמש כזה וגם בודקת את הסיסמא
    {
        commandString = string.Format("Select * from [client] where [UserName]='{0}' and [Pass1]='{1}'", username, password);
        Querry();
        dt = ds.Tables[0];
        if (dt.Rows.Count == 0)
            return new User();
        else
            return ConvertRow();
    }

    public List<User> SelectAll()  //  פעולה המציגה את כל המשתמשים הרשומים
    {
        users = new List<User>();
        commandString = string.Format("Select * from [client]");
        Querry();
        dt = ds.Tables[0];
        ConvertList();
        return users;        
    }

    public List<User> SelectBySnif(string snif)  //  פעולה המציגה את כל המשתמשים הרשומים בסניף
    {
        users = new List<User>();
        commandString = string.Format("Select * from [client]");  // משתנה שמגדיר את השאילתא שצריך להריץ
        if (snif != "")
        {
            commandString += string.Format(" Where [snif]='{0}'", snif);  // מגדיר תנאי לחיפוש
        }
        Querry();  // ריץ את השאילתא
        dt = ds.Tables[0];
        ConvertList();  // מייצר רשימת משתמשים מהתוצאה
        return users;
    }

    public int AddUser(User data)  //  שאילתת הוספת משתמש
    {
        commandString = string.Format("INSERT INTO [client] Values('{0}','{1}','{2}','{3}','{4}',{5})", data.UserName,data.Pass1,data.Mail,data.Phone,data.Snif,data.Level);
        NonQuerry();
        return rowsAffected;
    }

    public int UpdateUser(User data)  //  שאילתת עדכון פרטי המשתמש
    {
        commandString = string.Format("UPDATE [client] SET [Pass1]='{0}',[Mail]='{1}',[Phone]='{2}',[Level]={3} WHERE [UserName]='{4}' ", data.Pass1, data.Mail, data.Phone,data.Level, data.UserName);
        NonQuerry();
        return rowsAffected;
    }

    public int DeleteUser(User data)  //   שאילתת מחיקת המשתמש
    {
        commandString = string.Format("DELETE FROM [client] WHERE UserName='{0}'", data.UserName);
        NonQuerry();
        return rowsAffected;
    }
}