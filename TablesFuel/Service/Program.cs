using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Fuel.Buisnes.Managers.Abstract;
using Fuel.Buisnes.Managers.Concrete;

namespace Service
{
    class Program
    {
        static public IRegionManager _regionManager;
        static public IAZSManager _AZSManager;
        static public IFuelManager _FuelManager;

        static void Main(string[] args)
        {
            string connStr = ConfigurationManager.ConnectionStrings["FuelEntities"].ConnectionString;
            _regionManager = new RegionManager(connStr);
            _AZSManager = new AZSManager(connStr);
            _FuelManager = new FuelinAZSManager(connStr);

            var regions = _regionManager.GetAll();
            var AZSes = _AZSManager.GetAll();
            var fuel = _FuelManager.GetAll();

           
        }
    }
}
