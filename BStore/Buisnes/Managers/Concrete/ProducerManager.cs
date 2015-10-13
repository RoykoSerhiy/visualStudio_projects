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
    public class ProducerManager : AbstractManager , IProducerManager
    {
         public ProducerManager(string connStr) : base(connStr) { }

        public IEnumerable<Producer> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Producer>().ToList();
            }
        }

        public bool AddProducer(string Name, string Adress , string Phone)
        {
            using (DbContext ctx = CreateDbContext())
            {
                ctx.Set<Producer>().Add(new Producer
                {
                    Name = Name,
                    Address = Adress,
                    Phone = Phone
                });
                ctx.SaveChanges();
                return true;
            }
        }
    }
}
