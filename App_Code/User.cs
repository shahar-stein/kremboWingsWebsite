using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User // מכיל את כל המידע על המשתמשים
{
    private string username;
    private string pass1;
    private string mail;
    private string phone;
    private string snif;
    private int level;

    public User()  // כשהשם משתמש ריק - זאת אומרת שהלקוח לא רשום באתר - אורח
    {
        UserName = "Visitor";
        Level = 0;
    }

    public User(string u, string p, string  m, string ph, string s, int l)  // פעולה בונה משתמש עם כל פרטיו
    {
        username = u;
        pass1 = p;
        mail = m;
        phone = ph;
        snif = s;
        level = l;
    }

    public string UserName { set { username = value; } get { return username; } }   // גטים וסטים לכל תכונות המשתמש
    public string Pass1 { set { pass1 = value; } get { return pass1; } }
    public string Mail { set { mail = value; } get { return mail; } }
    public string Phone { set { phone = value; } get { return phone; } }
    public string Snif { set { snif = value; } get { return snif; } }
    public int Level { set { level = value; } get { return level; } }
}