using Buisnes.Managers.Asbstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnes.Managers.Concrete
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
