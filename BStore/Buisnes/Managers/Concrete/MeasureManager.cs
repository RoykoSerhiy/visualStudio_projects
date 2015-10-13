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
    public class MeasureManager : AbstractManager , IMeasureManager
    {
         public MeasureManager(string connStr) : base(connStr) { }

        public IEnumerable<Measure> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Measure>().ToList();
            }
        }
    }
}
