using CodeFirst;
using CodeFirst.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDll
{
    public class HistoryManager
    {
        private static UserProfileContext context = UserProfileContext.Instance;
        public List<History> GetAll()
        {
            var list = context.History.ToList();
            return list;
        }
        public List<History> GetUserHistory(int id)
        {

            return context.History.Include("Driver").Include("Driver.Car").Include("User").OrderBy(h => h.StartTime).Where(h => h.User.Id == id).ToList();
        }
        public List<History> GetDriverHistory(int id)
        {

            return context.History.Include("Driver").Include("Driver.Car").Include("User").OrderBy(h => h.StartTime).Where(h => h.Driver.Id == id).ToList();
        }
        public List<History> GetUHRange(int id, int startIndex, int count)
        {
            
            return context.History.Include("Driver").Include("Driver.Car").Include("User").OrderBy(h => h.StartTime).Skip(startIndex).Take(count).Where(h => h.User.Id == id).ToList();
        }
        public List<History> GetDHRange(int id, int startIndex, int count)
        {

            return context.History.Include("Driver").Include("Driver.Car").Include("User").OrderBy(h => h.StartTime).Skip(startIndex).Take(count).Where(h => h.Driver.Id == id).ToList();
        }
        public int HistoryCountUsers(int id)
        {
            return context.History.Where(h=>h.User.Id == id).Count();
        }
        public int HistoryCountDrivers(int id)
        {
            return context.History.Where(h => h.Driver.Id == id).Count();
        }
        public History GetById(int id)
        {
            return context.History.Include("Driver").Include("Driver.Car").Include("User").First(h => h.Id == id);
        }
        public void Delete(History history)
        {
            var delHistory = context.History.Include("Driver").Include("User").First(h => h.Id == history.Id);
            context.History.Remove(delHistory);
            context.SaveChanges();
        }
        public void Update(History history)
        {
            var newHistory = context.History.Include("Driver").Include("User").First(h => h.Id == history.Id);

            newHistory.Driver = history.Driver;
            newHistory.User = history.User;
            newHistory.DepatureAddress = history.DepatureAddress;
            newHistory.DestinationAddress = history.DestinationAddress;
            newHistory.StartTime = history.StartTime;
            newHistory.FinishTime = history.FinishTime;

            context.Entry<History>(newHistory).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
