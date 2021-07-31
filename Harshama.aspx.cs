
using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)   // מטפל באירוע - טעינת דף
    {
        if (Request.Form["name1"] != null)
        {
            /*            string path = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= |DataDirectory|\Database1.accdb; Persist Security Info = True";
                        OleDbConnection conn = new OleDbConnection(path);
                        string username = Request.Form["name1"];
                        // Session["user"] = username;

                        string sql1 = "Select * from [client] where [UserName]='" + username + "'";
                        OleDbCommand cmd = new OleDbCommand(sql1, conn);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);  // source DB
                        DataSet ds = new DataSet();  // Virtual DB
                        da.Fill(ds, "client");  // ממלא את הדתא המקורי
                        DataTable dt = ds.Tables[0]; //  מסייע לראות את הדברים בצורה טבלאית
                        if (dt.Rows.Count == 0) // האם יש כזה משתמש רשום
                        {
                            string name = Request.Form["name1"];
                            string gender = Request.Form["gender"];
                            string password = Request.Form["pass1"];
                            string email = Request.Form["mail"];
                            string phone = Request.Form["phone"];
                            string snif = Request.Form["snif"];
                            int level = 2;
                            string sql2 = string.Format("INSERT INTO [client] Values('{0}','{1}','{2}','{3}','{4}',{5})",username, password, email, phone,snif, level);
                            OleDbCommand cmmd = new OleDbCommand(sql2, conn);
                            conn.Open();
                            cmmd.ExecuteNonQuery();  // ביצוע SQL
                            conn.Close();
                            Response.Redirect("./default.aspx");
                        }

                        else  // אם קיים משתמש כזה
                        {
                            Label lbl = new Label();
                            lbl.Text = "<script type = text/javascript>alert('שם קיים שם משתמש');</script>";
                            Page.Controls.Add(lbl);  // הוספת תווית הודעה לדף
                        }
            */
            User temp = new User(Request["name1"], Request["pass1"], Request["mail"], Request["phone"], Request["snif"], 2); //  בקשה מהלקוח לשרת - בודק אם המשתמש קיים, ואם כן רושם אותו במאגר הנתונים
            DbLinker link = new DbLinker();
            if(link.IsExist(temp.UserName).UserName=="Visitor")
            {
                if(link.AddUser(temp)!=0)
                {
                    Session["User"] = temp;
                    Response.Redirect("Default.aspx");  // ריספונס - תגובת השרת
                }
            }
            else
            {
                Response.Redirect("Exists.aspx");
            }

        }
    }
}



