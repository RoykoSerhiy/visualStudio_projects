using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fuel.Entities;

namespace Fuel.Buisnes.Managers.Abstract
{
    public interface IAZSManager : IManager
    {
        IEnumerable<AZS> GetAll();
    }
}
