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
    public class ProductManager : AbstractManager , IProductManager
    {
        public ProductManager(string connStr) : base(connStr) { }

        public IEnumerable<Product> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Product>().ToList();
            }
        }

        public bool AddProduct(string Name, int CategoryID , int ProducerID)
        {
            using (DbContext ctx = CreateDbContext())
            {
                ctx.Set<Product>().Add(new Product
                {
                    Name = Name,
                    CategoryId = CategoryID,
                    ProducerId = ProducerID
                });
                ctx.SaveChanges();
                return true;
            }
        }
    }
}
