using CodeFirst;
using CodeFirst.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDll
{
    public class CityManager
    {
        private static UserProfileContext context = UserProfileContext.Instance;
        public List<Region> GetRegions()
        {
            return context.City.Include("Regions").First().Regions.ToList();
        }
        public Region GetRegionsById(int id)
        {
            List<Region> regions = new List<Region>();
            regions = context.City.Include("Regions").First().Regions.ToList();
            return regions.First(r => r.Id == id);
        }
        public List<Street> GetStreets()
        {
            List<Street> streets = new List<Street>();
            streets = context.Street.ToList();
            return streets;
        }
        
    }
}
