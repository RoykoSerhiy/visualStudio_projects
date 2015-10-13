using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014_10_06Prj
{
    class Program
    {
        static void Main()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["TestDatabaseEntities"].ConnectionString;

            using (DbContext ctx = new DbContext(connectionString))
            {
                List<Worker> workers = ctx.Set<Worker>().ToList();
                foreach (var w in workers)
                {
                    Console.WriteLine(w);
                }
            }
        }
    }
}
