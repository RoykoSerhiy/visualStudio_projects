using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main()
        {

            using (var ctx = new TestDatabaseEntities())
            {
                ctx.Database.Log = Console.WriteLine;
                var workers = ctx.Workers;
                foreach (var w in workers)
                {
                    Console.WriteLine(w);
                }
            }


            /*
            string connectionString =
                ConfigurationManager.ConnectionStrings["TestDatabaseEntities"].ConnectionString;

            using (DbContext ctx = new DbContext(connectionString))
            {
                ctx.Database.Log = Console.WriteLine;

                List<Worker> workers = ctx.Set<Worker>().ToList();
                foreach (var w in workers)
                {
                    Console.WriteLine(w);
                }
            }
             */


        }
    }
}
