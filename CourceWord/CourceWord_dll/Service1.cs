using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CourceWord_dll
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class CourceWordService : IServiceEmployeesDataBase
    {
        List<DataEmployees> employees;
        List<Info> info;

        public List<DataEmployees> Get()
        {
            employees = new List<DataEmployees>();
            info = new List<Info>();

            try
            {
                using(DbContext ctx = new DbContext(ConfigurationManager.ConnectionStrings["EmployeesEntities"].ConnectionString))
                {
                    info = ctx.Set<Info>().ToList();
                }

                foreach (Info i in info)
                {
                    employees.Add(new DataEmployees 
                    { Name = i.Name, Address = i.Address, Post = i.Post }
                    );
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employees;
        }


        public string Test()
        {
            return "Test compleat";
        }
    }
}
