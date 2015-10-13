using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvmDemo.Business.Managers.Abstract;
using mvvmDemo.Entities;

namespace mvvmDemo.Business.Managers.Concrete
{
    public class WorkersManager : AbstractManager, IWorkersManager
    {

        public WorkersManager(string connectionString) : base(connectionString) { } 



        public IEnumerable<Worker> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Worker>().ToList();
            }
        }
    }
}
