using CodeFirst;
using CodeFirst.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDll
{
    public class UserInfoManager
    {
        private static UserProfileContext context = UserProfileContext.Instance;
        public UserInfo GetByLogin(string login)
        {
            var id = context.UserInfo.First(d => d.Login == login).Id;
            return ((UserInfo)context.User.Include("History").FirstOrDefault(u => u.Id == id) ?? (UserInfo)context.Driver.Include("Car").Include("History").FirstOrDefault(d => d.Id == id));
                
        }
    }
}
