using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BStore.Entities;

namespace Buisnes.Managers.Abstract
{
    public interface ICategoryManager : IManager
    {
        IEnumerable<Category> GetAll();
        bool AddCategory(string CategoryName, string subCategoryName);
        bool AddSubCategory(int id, string subCategoryName);
    }
}
