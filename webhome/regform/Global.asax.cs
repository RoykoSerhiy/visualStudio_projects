using regform.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace regform
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            var securityService = SecurityService.SecurityServiceInstance;
            securityService.RefreshPrincipal();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            try
            {
                Exception lastError = Server.GetLastError();
                if (lastError != null)
                {
                    Server.Transfer("~/Error/ErrorPage.aspx");
                }
            }
            catch
            {
                Response.Write("Unexpected error has occured");
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}