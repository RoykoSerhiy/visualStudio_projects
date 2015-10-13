using Fuel.Buisnes.Managers.Abstract;
using Fuel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Buisnes.Managers.Concrete
{
    public class FuelinAZSManager : AbstractManager , IFuelManager
    {
         public FuelinAZSManager(string connStr) : base(connStr) { }

        public IEnumerable<FuelinAZS> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<FuelinAZS>().ToList();
            }
        }
    }
}
