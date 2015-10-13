using CodeFirst;
using CodeFirst.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDll
{
    public class DriverManager
    {
        private static UserProfileContext context = UserProfileContext.Instance;
        public List<Driver> GetAll()
        {
            var list = context.Driver.Include("Car").ToList();
            return list;
        }
        public Driver GetByLogin(string login)
        {
            return context.Driver.Include("Car").First(d => d.Login == login);
        }
        public List<Driver> GetRange(int startIndex, int count)
        {
            return context.Driver.Include("Car").OrderBy(d => d.Name).Skip(startIndex).Take(count).ToList();
        }
        public int DriverCount()
        {
            return context.Driver.Count();
        }
        public Driver GetById(int id)
        {
            return context.Driver.Include("Car").First(d => d.Id == id);
        }
        public void Delete(Driver driver)
        {
            var delDriver = context.Driver.Include("Car").First(d => d.Id == driver.Id);
            var delCar = context.Car.First(c => c.Id == delDriver.Car.Id);
            context.Car.Remove(delCar);
            context.Driver.Remove(delDriver);
            context.SaveChanges();
        }
       
        public void Insert(Driver driver)
        {
            Driver newDriver = new Driver();
            newDriver.Name = driver.Name;
            newDriver.Surname = driver.Surname;
            newDriver.MiddleName = driver.MiddleName;
            newDriver.Phone = driver.Phone;
            newDriver.Login = driver.Login;
            newDriver.Password = driver.Password;
            newDriver.LicenseNum = driver.LicenseNum;
            newDriver.LicenseValidDate = driver.LicenseValidDate;
            newDriver.Nationality = driver.Nationality;
            newDriver.Car = driver.Car;
           

            context.Entry<Driver>(newDriver).State = System.Data.Entity.EntityState.Added;

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                var e = ex;
            }

        }
        
        //public void Insert(string Name , string Surname ,string MiddleName , string Phone ,Nationality Nationality,string Login , string Password )
        //{
        //    Driver newDriver = new Driver();
        //    newDriver.Name = Name;
        //    newDriver.Surname = Surname;
        //    newDriver.MiddleName = MiddleName;
        //    newDriver.Phone = Phone;
        //    newDriver.Login = Login;
        //    newDriver.Password = Password;
        //    //newDriver.LicenseNum = LicenseNum;
        //    //newDriver.LicenseValidDate = LicenseValidDate;
        //    newDriver.Nationality = Nationality;
        //   
        //    context.Entry<Driver>(newDriver).State = System.Data.Entity.EntityState.Added;
        //
        //    context.SaveChanges();
        //
        //}
        public void Update(Driver driver)
        {
            var newDriver = context.Driver.Include("Car").First(d => d.Id == driver.Id);

            newDriver.Name = driver.Name;
            newDriver.Surname = driver.Surname;
            newDriver.MiddleName = driver.MiddleName;
            newDriver.Phone = driver.Phone;
            newDriver.Login = driver.Login;
            newDriver.Password = driver.Password;
            newDriver.Nationality = driver.Nationality;
            newDriver.LicenseNum = driver.LicenseNum;
            newDriver.LicenseValidDate = driver.LicenseValidDate;
            newDriver.Car = driver.Car;
            
            context.Entry<Driver>(newDriver).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
