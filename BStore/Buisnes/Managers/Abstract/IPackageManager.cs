using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BStore.Entities;

namespace Buisnes.Managers.Abstract
{
    public interface IPackageManager : IManager
    {
        
        IEnumerable<Package> GetAll();
        bool AddPackage(decimal volume, int volumeMeasId, int measureId, int prodId);
    }
   
}
