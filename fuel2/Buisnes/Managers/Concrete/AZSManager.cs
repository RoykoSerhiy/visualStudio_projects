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
    public class AZSManager : AbstractManager , IAZSManager
    {
        public AZSManager(string connStr) : base(connStr) { }

        public IEnumerable<AZS> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<AZS>().ToList();
            }
        }
    }
}
