<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Harshama.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="css/site.js?version=3">
    </script>        <!--דף המבצע בדיקות תקינות קלט בקובץ נפרד JS -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<div id="main">
    <h1>טופס הרשמה !</h1>
    <br />
    <form name="myform" onsubmit="return CheckForm()" method="post">
        <table>
            <tr>
                <td>שם משתמש :</td>
                <td>
                    <input type="text" id="name1" name="name1" />
                </td>
            </tr>
            <tr>
                <td>סיסמא :</td>
                <td>
                    <input type="text" id="pass1" name="pass1" />
                </td>
            </tr>
            <tr>
                <td>אימות סיסמא :</td>
                <td>
                    <input type="text" id="pass2" name="pass2" />
                </td>
            </tr>
            <tr>
                <td>איימל :</td>
                <td>
                    <input type="text" id="mail" name="mail" />
                </td>
            </tr>
            <tr>
                <td>בחר מגדר :</td>
                <td>זכר
                <input type="radio" id="gender" name="gender" value="male" checked="checked"/>
                    נקבה<input type="radio" id="gender1" name="gender" value="female" />
                </td>
            </tr>
            <tr>
                <td>הקלד מספר טלפון :</td>
                <td>
                    <input type="number" id="phone" name="phone" dir="ltr" />
                </td>
            </tr>
            <tr>
                <td>בחר סניף :</td>
                <td>
                    <select id="snif" name="snif">
                        <option></option>
                        <option>ראשון לציון</option>
                        <option>אופקים</option>
                        <option>אילת</option>
                        <option>אשדוד</option>
                        <option>אשקלון</option>
                        <option>באר שבע</option>
                        <option>בית שאן</option>
                        <option>בת ים</option>
                        <option>גבעתיים</option>
                        <option>דימונה</option>
                        <option>הוד השרון</option>
                        <option>הרצליה</option>
                        <option>חדרה</option>
                        <option>חולון</option>
                        <option>חיפה</option>
                        <option>טבריה</option>
                        <option>יבנה</option>
                        <option>יהוד</option>
                        <option>יפו</option>
                        <option>יקנעם</option>
                        <option>ירושלים</option>
                        <option>כפר סבא</option>
                        <option>תל אביב</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="submit" name="submit" id="submit" value="שלח" />
                </td>
                <td>
                    <input type="reset" name="reset" id="reset" value="מחק" />
                </td>
            </tr>
        </table>
    </form>
</div>

</asp:Content>
