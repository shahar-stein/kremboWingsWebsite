<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Update.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="css/site.js?version=3">
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<div id="main">
    <h1>טופס עדכון פרטים !</h1>
    <br />
    <form name="myform" onsubmit="return CheckUpdate()" method="post">
        <table>
            <tr>
                <td>שם משתמש :</td>
                <td>
                    <input type="text" disabled="disabled" id="name1" name="name1" value="<%=(Session["User"] as User).UserName %>" />
                </td>
            </tr>
            <tr>
                <td>סיסמא :</td>
                <td>
                    <input type="text" id="pass1" name="pass1" value="<%=(Session["User"] as User).Pass1 %>" />
                </td>
            </tr>
            <tr>
                <td>אימות סיסמא :</td>
                <td>
                    <input type="text" id="pass2" name="pass2" value="<%=(Session["User"] as User).Pass1 %>"/>
                </td>
            </tr>
            <tr>
                <td>איימל :</td>
                <td>
                    <input type="text" id="mail" name="mail" value="<%=(Session["User"] as User).Mail %>"/>
                </td>
            </tr>
            <tr>
                <td>הקלד מספר טלפון :</td>
                <td>
                    <input type="text" id="phone" name="phone" dir="ltr" value="<%=(Session["User"] as User).Phone %>"/>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="submit" id="submit" name="submit" value="עדכן"/>
                </td>
            </tr>
        </table>
    </form>
</div>

</asp:Content>
