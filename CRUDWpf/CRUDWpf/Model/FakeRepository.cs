using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWpf.Model
{
    public class FakeRepository : IRepository
    {

        private List<Worker> _workers = new List<Worker>();
        private int _nextId = 1;

        public FakeRepository()
        {
            Add(new Worker { 
                FirstName = "Roberto",
                LastName = "Bugatti",
                Position = "boss",
                Phone = "111-111-11"
            });
            Add(new Worker
            {
                FirstName = "Carlos",
                LastName = "Rodriguez",
                Position = "manager",
                Phone = "111-111-22"
            });
            Add(new Worker
            {
                FirstName = "Don",
                LastName = "Chucho",
                Position = "RAB",
                Phone = "111-111-33"
            });
            Add(new Worker
            {
                FirstName = "Stepan",
                LastName = "Bandera",
                Position = "boss",
                Phone = "111-111-12"
            });
            Add(new Worker
            {
                FirstName = "Misha",
                LastName = "Buhalow",
                Position = "alkash",
                Phone = "000-000-00"
            });
        }

        public IEnumerable<Worker> GetAll()
        {
            return _workers;
        }

        public Worker Get(int id)
        {
            return _workers.Find(w => w.Id == id);
        }

        public Worker Add(Worker item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item Is Null");

            }
            item.Id = _nextId++;
            _workers.Add(item);

            return item;

        }

        public void Remove(int id)
        {
            _workers.RemoveAll(w => w.Id == id);
        }

        public bool Update(Worker item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item Is Null");

            }
            int i = _workers.FindIndex(w => w.Id == item.Id);

            if (i == -1)
            {
                return false;
            }
            _workers.RemoveAt(i);
            _workers.Add(item);
            _workers = _workers.OrderBy(w => w.Id).ToList();

            return true;
        }
    }
}
