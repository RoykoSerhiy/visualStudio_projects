using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Entities;

namespace EFdemo.WpfUi.Models
{
    public class Repository : IRepository
    {

        public IEnumerable<Worker> GetAll()
        {
            List<Worker> res = new List<Worker>();
            using (var ctx = new TestDatabaseEntities())
            {
                res = ctx.Workers.ToList();
            }
            return res;
        }
        
        public Worker Get(int id)
        {
            Worker res = null;
            using (var ctx = new TestDatabaseEntities())
            {
                res = ctx.Workers.Where(w => w.id == id).First();

            }
            return res;
        }

        public Worker Add(Worker item)
        {
            using(var ctx = new TestDatabaseEntities())
            {
                ctx.Workers.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public void Remove(int id)
        {
            using (var ctx = new TestDatabaseEntities())
            {
                Worker res = ctx.Workers.Where(w => w.id == id).First();

                ctx.Entry(res).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public bool Update(Worker item)
        {
            using (var ctx = new TestDatabaseEntities())
            {
                Worker wrkUpdate =
                    ctx.Workers.Where(w => w.id == item.id).First();
                if (wrkUpdate != null)
                {
                    wrkUpdate.FirstName = item.FirstName;
                    wrkUpdate.LastName = item.LastName;
                    wrkUpdate.Position = item.Position;
                    wrkUpdate.Phone = item.Phone;
                }
                else
                {
                    return false;
                }
                ctx.Entry(wrkUpdate).State = EntityState.Modified;
                ctx.SaveChanges();


            }
            return true;
        }


        public IEnumerable<Order> GetOrder(int W_id)
        {
            List<Order> res = null;
            using (var ctx = new TestDatabaseEntities())
            {
                res = ctx.Orders.Where(o => o.WorkerId == W_id).ToList();
            }
            return res;
        }


        public Order AddOrders(Order o)
        {
            using (var ctx = new TestDatabaseEntities())
            {
                ctx.Orders.Add(o);
                ctx.SaveChanges();
            }
            return o;
        }





        public void OrderRemove(int id)
        {
             using (var ctx = new TestDatabaseEntities())
            {
                Order res = ctx.Orders.Where(o => o.id == id).First();

                ctx.Entry(res).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }


        public bool OrderUpdate(Order o)
        {

            using (var ctx = new TestDatabaseEntities())
            {
                Order ordUpdate =
                    ctx.Orders.Where(or => or.id == o.id).First();
                if (ordUpdate != null)
                {
                    ordUpdate.Price = o.Price;
                    ordUpdate.Description = o.Description;
                }
                else
                {
                    return false;
                }
                ctx.Entry(ordUpdate).State = EntityState.Modified;
                ctx.SaveChanges();


            }
            return true;
        }
    }
}
