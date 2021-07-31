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
        if (Request.Form["username"] != null)
        {
            DbLinker link = new DbLinker();  // יצירת מופע הלינקר
            User temp = link.IsExist(Request["username"], Request["pass"]);
            Session["User"] = temp;
            if (temp.UserName == "Visitor")
            {
                Response.Redirect("Block.aspx");
            }
            else
            {
                Response.Redirect("Default.aspx");
            }

            /*            string path = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= |DataDirectory|\Database1.accdb; Persist Security Info = True"; 
                        OleDbConnection conn = new OleDbConnection(path);
                        string username = Request.Form["username"];
                        Session["user"] = username;
                        string pass = Request.Form["pass"];
                        string level = Request.Form["level"];
                        string sql = "Select * from [client] where [UserName]='" + username + "' and [Pass1]='" + pass + "' and [Level]='" + level + "'";
                        OleDbCommand cmmd = new OleDbCommand(sql, conn);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmmd);  // source DB
                        DataSet ds = new DataSet();  // Virtual DB
                        da.Fill(ds, "client");  // ממלא את הדתא המקורי
                        DataTable dt = ds.Tables[0]; //  מסייע לראות את הדברים בצורה טבלאית
                        if (dt.Rows.Count != 0) // האם יש כזה משתמש רשום
                        {
                           Session["UserData"] = dt;
                            if (level == "1")
                            {
                                Response.Redirect("manager.aspx");
                            }
                            if (level == "2")
                            {
                                Response.Redirect("People.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("Harshama.aspx");
                        }
                    }
                    else
                    {
                       // Session["UserData"] = null;
            */
        }
    }
}