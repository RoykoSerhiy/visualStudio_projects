using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace Buisnes.Managers.Asbstract
{
    public interface IRegionManager : IManager
    {
        IEnumerable<Region> GetAll();

    }
}
