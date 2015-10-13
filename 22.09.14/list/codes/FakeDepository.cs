using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list.codes
{
    class FakeDepository : IDepository
    {
        public List<Worker> GetWorkers()
        {
            List<Worker> res = new List<Worker>();

            res.Add(new Worker() { 
                Id = 1,
                fName = "Vasya",
                lName = "Rak",
                Position = "No Boss",
                Phone = "123-321-2"
            });
            res.Add(new Worker()
            {
                Id = 2,
                fName = "Petro",
                lName = "Bulkin",
                Position = "Boss",
                Phone = "123-321-1"
            });
            res.Add(new Worker()
            {
                Id = 3,
                fName = "Mukola",
                lName = "Invalid",
                Position = "Noob",
                Phone = "123-321-0"
            });
            return res;
        }
        public Worker GetWorkerById(int id)
        {
            throw new NotImplementedException();
        }





        public void AddWorker(Worker w)
        {
            throw new NotImplementedException();
        }


        public void DeleteWorker(int id)
        {
            throw new NotImplementedException();
        }


        public void UpdateWorker(int id, Worker w)
        {
            throw new NotImplementedException();
        }
    }
}
