using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list.codes
{
    interface IDepository
    {
        List<Worker> GetWorkers();
        Worker GetWorkerById(int id);
        void AddWorker(Worker w);
        void DeleteWorker(int id);
        void UpdateWorker(int id, Worker w);
    }
}
