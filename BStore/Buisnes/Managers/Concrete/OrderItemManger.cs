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
    public class OrderItemManager : AbstractManager , IOrderItemManager
    {
         public OrderItemManager(string connStr) : base(connStr) { }

        public IEnumerable<OrderItem> GetAll()
        {
            using (DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<OrderItem>().ToList();
            }
        }
    }
}
