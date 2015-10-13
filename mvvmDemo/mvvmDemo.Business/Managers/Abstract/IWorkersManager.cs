using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvmDemo.Entities;

namespace mvvmDemo.Business.Managers.Abstract
{
    public interface IWorkersManager : IManager
    {
        IEnumerable<Worker> GetAll();
    }
}
