using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BStore.Entities;

namespace Buisnes.Managers.Abstract
{
    public interface IMeasureManager : IManager
    {
        IEnumerable<Measure> GetAll();
    }
}
