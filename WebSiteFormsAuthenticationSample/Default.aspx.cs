using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool isPersistent = false;

        //  用 txtaccount  txtpassword 先去驗證一次帳密

     string   userData = "admin"; //這裡可以放角色 權限   admin, user 逗號隔開


        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
          txtAccount.Text,
          DateTime.Now,
          DateTime.Now.AddMinutes(30),
          isPersistent,
          userData,
          FormsAuthentication.FormsCookiePath);

        string encTicket = FormsAuthentication.Encrypt(ticket);

        // Create the cookie.
        Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));


        Response.Redirect("Index.aspx");
       
    }
}