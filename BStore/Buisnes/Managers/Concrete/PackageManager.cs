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
    public class PackageManager : AbstractManager , IPackageManager
    {
        public PackageManager(string connStr) : base(connStr) { }

        public IEnumerable<Package> GetAll()
        {
            using (DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Package>().ToList();
            }

        }
        public bool AddPackage(decimal volume , int volumeMeasId , int measureId , int prodId)
        {
            using (DbContext ctx = CreateDbContext())
            {
                ctx.Set<Package>().Add(new Package
                {
                    Volume = volume,
                    VolumeMeasureId = volumeMeasId,
                    MeasureId = measureId,
                    ProductId = prodId
                });
                ctx.SaveChanges();
                return true;
            }
        }
    }
}
