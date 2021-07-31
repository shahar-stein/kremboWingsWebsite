<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) // דף גלובל זהו דף שמייצר פעולות למצבים מסויימים של האתר
    {
        // Code that runs on application startup

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) // התחבר לקוח
    {
        // Code that runs when a new session is started
    }

    void Session_End(object sender, EventArgs e)  // לקוח עוזב
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

</script>
