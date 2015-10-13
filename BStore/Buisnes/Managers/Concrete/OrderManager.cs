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
    public class OrderManager : AbstractManager , IOrderManager
    {
        public OrderManager(string connStr) : base(connStr) { }

        public IEnumerable<Order> GetAll()
        {
            using (DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Order>().Where(o => o.OrderType == 1).ToList();
            }
        }

        public bool AddOrder(int customerId, DateTime time, decimal cost, int status, int orderType)
        {
            using (DbContext ctx = CreateDbContext())
            {
                ctx.Set<Order>().Add(new Order
                {
                    CustomerId = customerId,
                    Time = time,
                    Cost = cost,
                    Status = status,
                    OrderType = orderType
                });
                ctx.SaveChanges();
                return true;
            }

        }
    }
}
