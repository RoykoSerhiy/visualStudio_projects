﻿using EDModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamPrj.Buisnes.Managers.Abstract;

namespace TeamPrj.Buisnes.Managers.Concrete
{
    public class SupermarketManager : AbstractManager , ISupermarketManager
    {
         public SupermarketManager(string connStr) : base(connStr) { }

        public IEnumerable<Supermarkets> GetAll()
        {
            using(DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Supermarkets>().ToList();
            }
        }
    }
}
