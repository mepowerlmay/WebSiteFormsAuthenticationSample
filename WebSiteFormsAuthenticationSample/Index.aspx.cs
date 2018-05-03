using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (User.IsInRole("admin"))
            {
                //從 cookie 取回 ticket
                // 參考網址 https://dotblogs.com.tw/yc421206/2013/12/13/133999 
                HttpCookie cookies = Request.Cookies["XYZAuthCookie"];               
                FormsAuthenticationTicket oldTicket = FormsAuthentication.Decrypt(cookies.Value);

                Label1.Text = "管理者";
            }

            if (User.IsInRole("user"))
            {
                Label1.Text = "一般使用者";
            }
        }
    }
}