using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDemo.Business.Managers.Abstract
{
    public class AbstractManager : IManager

    {
        private readonly string _connectionString;
        public AbstractManager(string connectionString)
        {
            this._connectionString = connectionString;
        }
        protected DbContext CreateDbContext()
        {
            return new DbContext(_connectionString);
        }
    }
}
