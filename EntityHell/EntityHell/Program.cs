using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityHell.EFDM;
//using System.Data.Entity;

namespace EntityHell
{
    class Program
    {
        static void Main()
        {
            using (var ctx = new TestDatabaseEntities())
            {
                var worker = ctx.Workers;
                foreach (var w in worker)
                {
                    Console.WriteLine(w.LastName);
                }
            }
        }
    }
}
