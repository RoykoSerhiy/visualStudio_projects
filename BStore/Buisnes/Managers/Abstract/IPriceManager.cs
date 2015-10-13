using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BStore.Entities;

namespace Buisnes.Managers.Abstract
{
    public interface IPriceManager : IManager
    {
        IEnumerable<Price> GetAll();
        bool AddPrice(DateTime time, decimal unitCost, int packgeId);
    }
}
