using regform.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace regform.Login
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string lgn = login.UserName;
            string pass = login.Password;

            e.Authenticated = SecurityService.SecurityServiceInstance.Login(lgn, pass);
        }
    }
}