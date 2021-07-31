using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    DbLinker link = new DbLinker();

    protected void Page_Load(object sender, EventArgs e)
    {
        foreach(User u in link.SelectAll())  // מציג את כל משתמשי האתר שהמנהל יוכל לראות כשנכנס לדף המנהל
        {
            users.Items.Add(new ListItem(u.UserName, u.UserName));
        }
    }

    protected void usersClicked(object sender, EventArgs e)  //  הצגת פרטי המשתמש
    {
        User data = link.IsExist(users.Items[users.SelectedIndex].Value);
        name1.Value = data.UserName;
        pass1.Value = data.Pass1;
        mail.Value = data.Mail;
        phone.Value = data.Phone;
        Level.Value = data.Level.ToString();
        snif.Value = data.Snif;
    }

    protected void snifClicked(object sender, EventArgs e)  //  הצגת סניף המשתמש
    {
        string data = snifim.Items[snifim.SelectedIndex].Value;
        users.Items.Clear();
        foreach (User u in link.SelectBySnif(data))  // מציג את כל משתמשי האתר שרשומים לסניף הנבחר
        {
            users.Items.Add(new ListItem(u.UserName, u.UserName));
        }
    }

    protected void buttonClicked(object sender, EventArgs e)  //  עדכון פרטי המשתמש
    {
        int success;
        User temp = new User(name1.Value,pass1.Value,mail.Value,phone.Value,snif.Value,int.Parse(Level.Value));
        if ((sender as Button).Text == "עדכן")
            success = link.UpdateUser(temp);
        else
            success = link.DeleteUser(temp);
        if(success==1)  // תשובת השרת מנתבת אותך לאחד הדפים
        {
            Response.Redirect("Success.aspx");  
        }
        else
        {
            Response.Redirect("Fail.aspx");
        }
    }
}