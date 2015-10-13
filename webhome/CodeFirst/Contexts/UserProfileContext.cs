using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Contexts
{
    public class UserProfileContext : DbContext
    {
        public static UserProfileContext Instance { get; private set; }
        public UserProfileContext()
            : base("MyConnString")
        {
            Database.SetInitializer<UserProfileContext>(null);
            
        }
        static UserProfileContext()
        {
            Instance = new UserProfileContext();
        }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Administrator> Admins { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<City> City { get; set; }
        
    }
}
