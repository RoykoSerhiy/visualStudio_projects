using BStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnes.Managers.Abstract
{
    public interface IOrderManager
    {
        IEnumerable<Order> GetAll();
        bool AddOrder(int customerId , DateTime time , decimal cost , int status , int orderStatus);
    }
}
