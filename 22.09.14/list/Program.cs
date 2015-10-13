using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using list.codes;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker wrk = new Worker();
           // wrk.Id = 5;
            wrk.fName = "Alex";
            wrk.lName = "CT";
            wrk.Position = "CT";
            wrk.Phone = "123";

            IDepository repo = new DBDepository();
            
            
            Console.WriteLine("Added");
            //repo.AddWorker(wrk);
            Console.WriteLine("Removed");
            //repo.DeleteWorker(24);
            Console.WriteLine("Updated");
            repo.UpdateWorker(24, wrk);
            var workers = repo.GetWorkers();
            foreach (var w in workers)
            {
                Console.WriteLine(
                        w.Id + " " +
                        w.fName + " " +
                        w.lName + " " +
                        w.Position + " " +
                        w.Phone + " "
                    );
            }
            Console.WriteLine();
            var workerById = repo.GetWorkerById(2);
            Console.WriteLine(
                        workerById.Id + " " +
                        workerById.fName + " " +
                        workerById.lName + " " +
                        workerById.Position + " " +
                        workerById.Phone + " "
                    );
            
        }
    }
}
