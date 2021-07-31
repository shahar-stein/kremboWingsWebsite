
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.RequestType=="POST")  //  פוסט - נתוני השדות שבדף מצטרפים לשאילתא ריקווסט אבל הם מוסתרים - לא מופיעים בשורת הכתובת
        {
            User temp = Session["User"] as User;  // סשיין - משתנה מהשרת
            temp.Pass1 = Request["pass1"];  //  ריקווסט - בקשה מהשרת
            temp.Mail = Request["mail"];
            temp.Phone = Request["phone"];
            DbLinker link = new DbLinker();
            if (link.UpdateUser(temp) != 0)
            {
                Response.Redirect("Success.aspx");
            }
            else
            {
                Response.Redirect("Fail.aspx");
            }
        }

    }
}




