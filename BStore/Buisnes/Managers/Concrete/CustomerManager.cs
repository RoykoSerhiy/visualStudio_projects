using BStore.Entities;
using Buisnes.Managers.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnes.Managers.Concrete
{
    public class CustomerManager : AbstractManager , ICustomerManager
    {
        public CustomerManager(string connStr) : base(connStr) { }

        public IEnumerable<Customer> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Customer>().ToList();
            }
        }

        public bool AddCustomer(string name , string adress , string phone)
        {
            using (DbContext ctx = CreateDbContext())
            {
                ctx.Set<Customer>().Add(new Customer
                {
                   Name = name,
                   Address = adress,
                   Phone = phone
                });
                ctx.SaveChanges();
                return true;
            }

        }
    }
}
