


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="main">
        <h1>
            טופס התחברות !</h1>
        <br />
        <form name="myform" action="Login.aspx" method="post" enctype="text">
        <table>
            <tr>
                <td>
                    שם משתמש :
                </td>
                <td>
                    <input type="text" id="name1" name="username" />
                </td>
            </tr>
            <tr>
                <td>
                    סיסמא :
                </td>
                <td>
                    <input type="password" id="pass1" name="pass" />
                </td>
            </tr>
            <tr>
                <td>
                    <input type="submit" name="submit" id="submit" value="שלח" />
                </td>
            </tr>
        </table>
        </form>
    </div>
</asp:Content>
