<%@ Application Language="C#" %>

<script runat="server">



    
    void Application_AuthenticateRequest(object sender, EventArgs e){


    if (Request.IsAuthenticated) {
        // 先取得該使用者的 FormsIdentity
        FormsIdentity id = (FormsIdentity)User.Identity;
        // 再取出使用者的 FormsAuthenticationTicket
        FormsAuthenticationTicket ticket = id.Ticket;
        // 將儲存在 FormsAuthenticationTicket 中的角色定義取出，並轉成字串陣列
        string[] roles = ticket.UserData.Split(new char[] { ',' });
        // 指派角色到目前這個 HttpContext 的 User 物件去
        Context.User = new System.Security.Principal.GenericPrincipal(Context.User.Identity, roles);
    }
}

    void Application_Start(object sender, EventArgs e) 
    {
        // 在應用程式啟動時執行的程式碼

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  在應用程式關閉時執行的程式碼

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // 在發生未處理的錯誤時執行的程式碼

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // 在新的工作階段啟動時執行的程式碼

    }

    void Session_End(object sender, EventArgs e) 
    {
        // 在工作階段結束時執行的程式碼
        // 注意: 只有在  Web.config 檔案中將 sessionstate 模式設定為 InProc 時，
        // 才會引起 Session_End 事件。如果將 session 模式設定為 StateServer 
        // 或 SQLServer，則不會引起該事件。

    }
       
</script>
