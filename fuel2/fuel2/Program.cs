using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using Buisnes.Managers.Asbstract;
using Buisnes.Managers.Concrete;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace fuel2
{
    [DataContract]
    public class FuelResult
    {
        [DataMember]
        string FuelName;
        [DataMember]
        string AZSName;
        [DataMember]
        string RegionName;
        [DataMember]
        decimal Price;
    }
    [ServiceContract]
    public interface IMyFuel
    {
        [OperationContract]
        void Set(FuelResult r);
    }
    public class MyFuel
    {
        public 
    }
   

    class Program
    {
        

        static public IRegionManager _regionManager;
        static public IAZSManager _azsManager;
        static public IFuelManager _fuelManager;

        static void Main(string[] args)
        {
            Start();
            try
            {
                
                Console.WriteLine("Data writed into properties");
                ServiceHost sh = new ServiceHost(typeof());
                sh.AddServiceEndpoint(
                    typeof(),
                    new WSHttpBinding(),
                    "http://localhost/MyClass/Ep1"
                    );
                sh.Open();
                Console.WriteLine("Для завершения нажмите <ENTER>\n");
                Console.ReadLine();
                sh.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
        static void Start()
        {
            try
            {
                MyClass mc = new MyClass();

                string connStr = ConfigurationManager.ConnectionStrings["FuelEntities"].ConnectionString;
                _regionManager = new RegionManager(connStr);
                _azsManager = new AZSManager(connStr);
                _fuelManager = new FuelManager(connStr);

                string fn = "1";
                string an = "1";
                string rn = "1";
                decimal pr = 1;

                var regions = _regionManager.GetAll();
                var azs = _azsManager.GetAll();
                var fuel = _fuelManager.GetAll();

                var res =
                    from f in fuel
                    join a in azs
                    on f.AZSid equals a.id
                    join r in regions
                    on a.RegionId equals r.id
                    select new
                    {
                        Name = f.F_Name,

                        AName = a.AZS_Name,
                        Region = r.RegionName,
                        Price = f.F_Price
                    };

                foreach (var r in res)
                {
                    Console.WriteLine(r.Name + "->" + r.AName + "->" + r.Region + "->" + r.Price);
                   fn = r.Name;
                   an = r.AName;
                   rn = r.Region;
                   pr = Convert.ToDecimal(r.Price);

                }
                Console.WriteLine(fn + " " + an + " " + rn + " " + pr);
                mc.fuel_N = fn;
                mc.azs_N = an;
                mc.region_N = rn;
                mc.PRICE = pr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
