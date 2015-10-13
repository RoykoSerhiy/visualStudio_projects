using managerDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace regform.Security
{
    public class SecurityService
    {
        private static SecurityService service = null;
        private static AuthenticationProvider userAuth = new AuthenticationProvider();
        public static SecurityService SecurityServiceInstance
        {
            get
            {
                if (service == null)
                    service = new SecurityService();
                return service;
            }
        }

        public bool Login(string login, string pass, bool rememberme = false)
        {
            if (userAuth.IsValid(login, pass))
            {
                DefinePrincipal(login);
                return true;
            }
            return false;
        }

        public void DefinePrincipal(string login)
        {
            IIdentity identity = new GenericIdentity(login);
            string[] userRoles = userAuth.GetUserRoles(login);
            IPrincipal principal = new GenericPrincipal(identity, userRoles);
            HttpContext.Current.User = principal;
        }

        public void RefreshPrincipal()
        {
            var user = HttpContext.Current.User;
            if (user != null)
            {
                IIdentity identity = new GenericIdentity(user.Identity.Name);
                IPrincipal principal = new GenericPrincipal(identity, userAuth.GetUserRoles(user.Identity.Name));
                HttpContext.Current.User = principal;
            }
        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}