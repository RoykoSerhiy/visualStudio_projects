using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Buisnes.Managers.Asbstract
{
    public interface IAZSManager : IManager
    {
        IEnumerable<AZS> GetAll();
    }
}
