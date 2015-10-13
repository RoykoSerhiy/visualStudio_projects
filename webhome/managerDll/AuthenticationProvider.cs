using CodeFirst;
using CodeFirst.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDll
{
    public class AuthenticationProvider
    {
        private static UserProfileContext context = UserProfileContext.Instance;

        public string[] GetUserRoles(string login)
        {

            var user = context.UserInfo.Include("Roles").FirstOrDefault(u => u.Login == login);
            
            if (user != null)
            {
                
                return user.Roles.Select(r => r.Name).ToArray();
            }
            return new string[] { };
        }
        public bool LoginMach(string login)
        {
            return context.UserInfo.Any(u => u.Login == login);
        }
        public bool IsValid(string username, string password)
        {
            List<UserInfo> users = context.UserInfo.ToList();
            var user = users.FirstOrDefault(u => u.Login == username && u.Password == password);
            return user != null;
        }
    }
}
