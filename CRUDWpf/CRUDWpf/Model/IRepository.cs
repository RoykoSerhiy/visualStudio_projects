using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWpf.Model
{
    public interface IRepository
    {
        IEnumerable<Worker> GetAll();
        Worker Get(int id);
        Worker Add(Worker item);
        void Remove(int id);
        bool Update(Worker item);
    }
}
