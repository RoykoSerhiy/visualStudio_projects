using BStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnes.Managers.Abstract
{
    public interface ICustomerManager
    {
        IEnumerable<Customer> GetAll();
        bool AddCustomer(string name, string adress, string phone);
    }
}
