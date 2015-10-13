using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BStore.Entities;
using Buisnes.Managers.Abstract;

namespace Buisnes.Managers.Concrete
{
    public class CategoryManager : AbstractManager , ICategoryManager
    {
         public CategoryManager(string connStr) : base(connStr) { }

        public IEnumerable<Category> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Category>().ToList();
            }
        }

        public bool AddCategory(string categoryName, string subCategoryName)
        {
            using (DbContext ctx = CreateDbContext())
            {
                ctx.Set<Category>().Add(new Category
                {
                    Name = categoryName,
                    ParentId = null
                });
                ctx.SaveChanges();

                int parentId = Convert.ToInt32(ctx.Set<Category>()
                    .Where(c => c.Name == categoryName)
                    .Select(c => c.Id).First());

                ctx.Set<Category>().Add(new Category
                {
                    Name = subCategoryName,
                    ParentId = parentId
                });
                ctx.SaveChanges();
                return true;
            }

        }
        public bool AddSubCategory(int id , string subCategoryName)
        {
            using (DbContext ctx = CreateDbContext())
            {
                ctx.Set<Category>().Add(new Category
                    {
                        Name = subCategoryName,
                        ParentId = id
                    });
                ctx.SaveChanges();
                return true;
            }
        }
           
    }
}
