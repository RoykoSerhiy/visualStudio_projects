using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fuel.Entities;
using Fuel.Buisnes.Managers.Abstract;
using System.Data.Entity;

namespace Fuel.Buisnes.Managers.Concrete
{
    public class RegionManager : AbstractManager , IRegionManager
    {
         public RegionManager(string connStr) : base(connStr) { }

        public IEnumerable<Region> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Region>().ToList();
            }
        }
    }
}
