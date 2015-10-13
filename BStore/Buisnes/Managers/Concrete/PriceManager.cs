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
    public class PriceManager : AbstractManager , IPriceManager
    {

        public PriceManager(string connStr) : base(connStr) { }

        public IEnumerable<Price> GetAll()
        {
            using (DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Price>().ToList();
            }
        }
        public bool AddPrice(DateTime time, decimal unitCost, int packgeId)
        {
            using (DbContext ctx = CreateDbContext())
            {
                ctx.Set<Price>().Add(new Price
                {
                   Time = time,
                   UnitCost = unitCost,
                   PackageId = packgeId
                });
                ctx.SaveChanges();
                return true;
            }
        }
    }
}
