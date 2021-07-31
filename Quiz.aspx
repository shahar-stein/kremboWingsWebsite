<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Quiz.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form runat="server" method="post">
    <div id="main" runat="server">
        <center>
        <h1> ~ שאלון למשתמשים ~ </h1>

            <table dir="rtl" id="quizTable">
                <tr class="quizRow">
                    <td>
                        מתי נוסדה תנועת הנוער "כנפיים של קרמבו" ?
                    </td>
                    <td>
                        <input type="radio" name="quest1" value="1" />2002<br />
                        <input type="radio" name="quest1" value="2" />2009<br />
                        <input type="radio" name="quest1" value="3" />1997<br />
                    </td>
                </tr>
                <tr class="quizRow">
                    <td>
                        כמה סניפים קיימים לתנועת הנוער "כנפיים של קרמבו" ?
                    </td>
                    <td>
                        <input type="radio" name="quest2" value="1" />16<br />
                        <input type="radio" name="quest2" value="2" />למעלה מ55<br />
                        <input type="radio" name="quest2" value="3" />63<br />
                    </td>
                </tr>
                <tr class="quizRow">
                    <td>
                        מהי צבע חולצת התנועה ?
                    </td>
                    <td>
                        <input type="radio" name="quest3" value="1" />לבן<br />
                        <input type="radio" name="quest3" value="2" />צהוב<br />
                        <input type="radio" name="quest3" value="3" />כחול<br />
                    </td>
                </tr>
                <tr class="quizRow">
                    <td>
                        מי מבצע את המנון התנועה ?
                    </td>
                    <td>
                        <input type="radio" name="quest4" value="1" />שי המבר וילדי התנועה<br />
                        <input type="radio" name="quest4" value="2" />אייל גולן<br />
                        <input type="radio" name="quest4" value="3" />עברי לידר<br />
                    </td>
                </tr>
                <tr class="quizRow">
                    <td>
                       מי ייסד את תנועת הנוער כנפיים של קרמבו ?
                    </td>
                    <td>
                        <input type="radio" name="quest6" value="1" />אמו של כפיר ילד בעל מוגבלות<br />
                        <input type="radio" name="quest6" value="2" />אדם אנונימי בעל צרכים מיוחדים<br />
                        <input type="radio" name="quest6" value="3" />עדי אלטשולר<br />
                    </td>
                </tr>
                <tr class="quizRow">
                    <td>
                        מהו הגיל בו ניתן להדריך ב"כנפיים של קרמבו" ?
                    </td>
                    <td>
                        <input type="radio" name="quest5" value="1" />12 ומעלה<br />
                        <input type="radio" name="quest5" value="2" />14-18<br />
                        <input type="radio" name="quest5" value="3" />16<br />
                    </td>
                </tr>
                <tr class="quizRow">
                    <td>
                       מהו טווח הגילאים של החניכים בתנועה ?
                    </td>
                    <td>
                        <input type="radio" name="quest7" value="1" />7-21<br />
                        <input type="radio" name="quest7" value="2" />1-20<br />
                        <input type="radio" name="quest7" value="3" />6-18<br />
                    </td>
                </tr>

            </table>
            <input type="submit" value="שלח"/>
        </center>
    </div>
</form>

</asp:Content>

