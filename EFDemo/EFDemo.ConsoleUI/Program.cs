using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Entities;

namespace EFDemo.ConsoleUI
{
    class Program
    {
        static void Main()
        {
            using (var ctx = new TestDatabaseEntities())
            {
                //ctx.Database.Log = Console.WriteLine;
                var workers = ctx.Workers;
                //foreach (var w in workers)
                //{
                //    Console.WriteLine(w);
                //}

                //Delete
               //Worker wrkToDel = ctx.Workers.Where(w => w.id == 8).First();
               //ctx.Entry(wrkToDel).State = EntityState.Deleted;
               //ctx.SaveChanges();
               //workers = ctx.Workers;
               //Console.WriteLine("Changed");
               //foreach (var w in workers)
               //{
               //    Console.WriteLine(w);
               //}

               // Create
                //ctx.Workers.Add(new Worker
                //{
                //    FirstName = "Vahabit",
                //    LastName = "Vahabyte",
                //    Position = "Terrorist",
                //    Phone = "458-998-88"
                //});
                //ctx.SaveChanges();
                //
                //workers = ctx.Workers;
                //Console.WriteLine("Created");
                //foreach (var w in workers)
                //{
                //    Console.WriteLine(w);
                //}
                //
                //Update

                //Worker wrkUpdate = ctx.Workers.Where(w => w.id == 4).First();
                //if (wrkUpdate != null)
                //{
                //    wrkUpdate.FirstName = "Vahabit";
                //}
                //ctx.Entry(wrkUpdate).State = EntityState.Modified;
                //ctx.SaveChanges();
                //workers = ctx.Workers;
                //Console.WriteLine("upd");
                //foreach (var w in workers)
                //{
                //    Console.WriteLine(w);
                //}

                //SQl

                //int maxId = ctx.Workers.Max(w => w.id);
                //Console.WriteLine(maxId);
                //
                //string sql = 
                //    "DBCC CHECKIDENT (Workers , RESEED , " + maxId + ")";
                //var sqlRes = ctx.Workers.SqlQuery(sql);
                
                    IEnumerable<Order> res = ctx.Orders.Where(o => o.WorkerId ==2);
                foreach(Order o in res)
                {
                    Console.WriteLine(o.id + ". " + o.WorkerId + " "+o.Workers.FirstName + " " +o.Price  + " " +o.Description);
                }
                
               
                
            }
        }
    }
}
