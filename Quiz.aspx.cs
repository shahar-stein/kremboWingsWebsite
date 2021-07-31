using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) // דף דינאמי - משתנה, רץ בשרת
    {
        if (IsPostBack)
        {
            int count = 0;
            if (Request["quest1"] == "1")  // אם התשובה כפור מספר 1 אז קאונט פלוס פלוס
                count++;
            if (Request["quest2"] == "2")
                count++;
            if (Request["quest3"] == "3")
                count++;
            if (Request["quest4"] == "1")
                count++;
            if (Request["quest5"] == "2")
                count++;
            if (Request["quest6"] == "3")
                count++;
            if (Request["quest7"] == "1")
                count++;

            main.InnerHtml = string.Format("<center><h1 dir='ltr'> {0} הציון שלך </h1></center>",count);  // איינר HTML - מחליף את הדף ורושם את מה שבפנים
        }
    }
}