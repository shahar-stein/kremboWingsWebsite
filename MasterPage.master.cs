using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null)
            Session["User"] = new User();
        int level = (Session["User"] as User).Level;
        switch (level)  //  לפי רמת המשתמש - רמת ההרשאה של המחובר , נפתחים כפתורים דיאנמיים
        {
            case 0:
                HtmlGenericControl Li = new HtmlGenericControl("li");  // ליסט אייטם 
                HtmlGenericControl anchor = new HtmlGenericControl("a");  // אנקור
                anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "Login.aspx");
                anchor.InnerText = "התחברות";  // השם שאותו אני רוצה להציג
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                Li = new HtmlGenericControl("li");
                anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "Harshama.aspx");
                anchor.InnerText = "הרשמה";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                break;
            case 1:
                anchor = new HtmlGenericControl("a");
                Li = new HtmlGenericControl("li");
                anchor.Attributes.Add("href", "LogOut.aspx");
                anchor.InnerText = "התנתקות";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                Li = new HtmlGenericControl("li");
                anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "manager.aspx");
                anchor.InnerText = "דף מנהל";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                anchor = new HtmlGenericControl("a");
                Li = new HtmlGenericControl("li");
                anchor.Attributes.Add("href", "Report.aspx");
                anchor.InnerText = "כתבה";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                Li = new HtmlGenericControl("li");
                anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "Quiz.aspx");
                anchor.InnerText = "שאלון";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                break;
            case 2:
                anchor = new HtmlGenericControl("a");
                Li = new HtmlGenericControl("li");
                anchor.Attributes.Add("href", "LogOut.aspx");
                anchor.InnerText = "התנתקות";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                Li = new HtmlGenericControl("li");
                anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "Update.aspx");
                anchor.InnerText = "עדכן פרטים";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                anchor = new HtmlGenericControl("a");
                Li = new HtmlGenericControl("li");
                anchor.Attributes.Add("href", "Report.aspx");
                anchor.InnerText = "כתבה";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                Li = new HtmlGenericControl("li");
                anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "Quiz.aspx");
                anchor.InnerText = "שאלון";
                Li.Controls.Add(anchor);
                menu.Controls.Add(Li);
                break;
        }
    }
}
