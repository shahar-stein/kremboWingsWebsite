<%@ Page Title="דף הבית" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main">
        <h1 style="color:blue">  ~ דף הבית ~ </h1>
        <h2>שלום <%=(Session["User"] as User).UserName %></h2>  <!-- משתנה סשיין הוא משתנה גלובלי - לכל התחברות יש משתנה סשיין משלה ,  אייצ'טיאמל לא שומר מצב - כדי לזכור את הסטטוס יש משתנה גלובלי שהוא משתנה מהשרת <-->
        <ul>  
            <li>שם הנושא : תנועת הנוער כנפיים של קרמבו</li>
            <li>שם התלמידה : שחר שטיין</li>
            <li>כיתה : י'1</li>
            <li>שנת לימודים : תשע"ז</li>
            <li>שם המורה : רוית ברקוביץ' - אשר</li>
            <li>שם בית הספר : מקיף ה' - אמירים</li>
        </ul>
    </div>
    
</asp:Content>

