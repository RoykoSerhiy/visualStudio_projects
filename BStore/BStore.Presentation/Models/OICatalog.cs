using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BStore.Presentation.Models
{
    public class OICatalog
    {
          #region Ctor
        public OICatalog(int id, string productName,decimal quantity, decimal unitCost)
        {
            this.Id = id;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.UnitCost = unitCost;
            this.Cost = unitCost*quantity;
        }
        #endregion Ctor
        #region DataProperties
        public int Id { set; get; }
        public string ProductName { set; get; }
        public decimal Quantity { set; get; }
        public decimal UnitCost { set; get; }
        public decimal Cost { set; get; }
        #endregion DataProperties
    }
}
