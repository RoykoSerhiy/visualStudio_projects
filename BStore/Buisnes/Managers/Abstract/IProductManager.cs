using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BStore.Entities;

namespace Buisnes.Managers.Abstract
{
    public interface IProductManager : IManager
    {
        IEnumerable<Product> GetAll();
        bool AddProduct(string Name, int CategoryID, int ProducerID);
    }
    
}
