using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Buisnes.Managers.Asbstract
{
    public class AbstractManager
    {
        private readonly string _connectionString;

        public AbstractManager(string connStr)
        {
            this._connectionString = connStr;
        }

        protected DbContext CreateDbContext()
        {
            return new DbContext(_connectionString);
        }
    }
}
