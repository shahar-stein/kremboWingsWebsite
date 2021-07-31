<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="manager.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <form id="form1" runat="server">
                <h1> שלום מנהל ! <%=(Session["User"] as User).UserName %> </h1>
                <br />
                <div class="listBox">
                    <asp:ListBox id="users" runat="server" OnSelectedIndexChanged="usersClicked" AutoPostBack="true">
                    </asp:ListBox>             
                </div>
                <div class="listBox">
                    <asp:ListBox id="snifim" runat="server" OnSelectedIndexChanged="snifClicked" AutoPostBack="true">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>ראשון לציון</asp:ListItem>
                        <asp:ListItem>אופקים</asp:ListItem>
                        <asp:ListItem>אילת</asp:ListItem>
                        <asp:ListItem>אשדוד</asp:ListItem>
                        <asp:ListItem>אשקלון</asp:ListItem>
                        <asp:ListItem>באר שבע</asp:ListItem>
                        <asp:ListItem>בית שאן</asp:ListItem>
                        <asp:ListItem>בת ים</asp:ListItem>
                        <asp:ListItem>גבעתיים</asp:ListItem>
                        <asp:ListItem>דימונה</asp:ListItem>
                        <asp:ListItem>הוד השרון</asp:ListItem>
                        <asp:ListItem>הרצליה</asp:ListItem>
                        <asp:ListItem>חדרה</asp:ListItem>
                        <asp:ListItem>חולון</asp:ListItem>
                        <asp:ListItem>חיפה</asp:ListItem>
                        <asp:ListItem>טבריה</asp:ListItem>
                        <asp:ListItem>יבנה</asp:ListItem>
                        <asp:ListItem>יהוד</asp:ListItem>
                        <asp:ListItem>יפו</asp:ListItem>
                        <asp:ListItem>יקנעם</asp:ListItem>
                        <asp:ListItem>ירושלים</asp:ListItem>
                        <asp:ListItem>כפר סבא</asp:ListItem>
                        <asp:ListItem>תל אביב</asp:ListItem>                
                    </asp:ListBox> 
                </div>
                <div>
                    <table>
                        <tr>
                            <td>שם משתמש :</td>
                            <td>
                                <input type="text" disabled="disabled" id="name1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>סיסמא :</td>
                            <td>
                                <input type="text" id="pass1" disabled="disabled" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>איימל :</td>
                            <td>
                                <input type="text" id="mail" runat="server" disabled="disabled" />
                            </td>
                        </tr>
                        <tr>
                            <td>הקלד מספר טלפון :</td>
                            <td>
                                <input type="text" id="phone" runat="server" dir="ltr" disabled="disabled"/>
                            </td>
                        </tr>
                        <tr>
                            <td>סניף :</td>
                            <td>
                                <input type="text" id="snif" runat="server" dir="ltr" disabled="disabled"/>
                            </td>
                        </tr>
                        <tr>
                            <td>רמת משתמש :</td>
                            <td>
                                <input type="text" id="Level" runat="server" dir="ltr"/>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button id="update" runat="server" OnClick="buttonClicked" text="עדכן"/>
                            </td>
                            <td>
                                <asp:Button id="delete" runat="server" OnClick="buttonClicked" text="מחק"/>
                            </td>
                        </tr>
                    </table>
                </div>
        </form>
    </center>
</asp:Content>

