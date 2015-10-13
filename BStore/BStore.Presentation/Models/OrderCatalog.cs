using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BStore.Presentation.Models
{
    public class OrderCatalog
    {
        #region Ctor
        public OrderCatalog(int id, string customerName, DateTime time, decimal cost, int status)
        {
            this.Id = id;
            this.CustomerName = customerName;
            this.Time = time;
            this.Cost = cost;
            this.Status = status;
        }
        #endregion Ctor

        #region DataProperties
        public int Id { set; get; }
        public string CustomerName { set; get; }
        public DateTime Time { get; set; }
        public decimal Cost { set; get;}
        public int Status { set; get; }
        #endregion DataProperties
    }
}
