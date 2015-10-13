using CodeFirst;
using CodeFirst.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDll
{
    public class UserManager
    {
        private static UserProfileContext context = UserProfileContext.Instance;
        public List<User> GetAll()
        {
            var list = context.User.ToList();
            return list;
        }
        public User GetByLogin(string login)
        {
            return context.User.First(d => d.Login == login);
        }
        public User GetById(int id)
        {
            return context.User.First(u => u.Id == id);
        }
        public List<User> GetUserRange(int startIndex, int count)
        {
            System.Threading.Thread.Sleep(5000);
            return context.User.OrderBy(u => u.Name).Skip(startIndex).Take(count).ToList();
        }
        public int UserCount()
        {
            return context.User.Count();
        }
        public void Delete(User user)
        {
            var delUser = context.User.First(u => u.Id == user.Id);
           
            context.User.Remove(delUser);
            context.SaveChanges();
        }

        public void Insert(User user)
        {
            User newUser = new User();
            newUser.Name = user.Name;
            newUser.Surname = user.Surname;
            newUser.MiddleName = user.MiddleName;
            newUser.Phone = user.Phone;
            newUser.Login = user.Login;
            newUser.Password = user.Password;
            newUser.Nationality = user.Nationality;
           


            context.Entry<User>(newUser).State = System.Data.Entity.EntityState.Added;

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                var e = ex;
            }

        }
        
        public void Update(User user)
        {
            var newUser = context.User.First(u => u.Id == user.Id);

            newUser.Name = user.Name;
            newUser.Surname = user.Surname;
            newUser.MiddleName = user.MiddleName;
            newUser.Phone = user.Phone;
            newUser.Login = user.Login;
            newUser.Password = user.Password;
            newUser.Nationality = user.Nationality;



            context.Entry<User>(newUser).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
