using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BStore.Presentation.Models
{
    public class CatalogModel
    {
        #region Ctor
        public CatalogModel(int id, string name, string producer
            , string category, string subcategory, decimal volume, string volmesure, string measure , decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Producer = producer;
            this.Category = category;
            this.SubCategory = subcategory;
            this.Volume = volume;
            this.VolMeasure = volmesure;
            this.Measure = measure;
            this.Price = price;
        }
        #endregion Ctor




        #region DataProperties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public decimal Volume { get; set; }
        public string VolMeasure { get; set; }
        public string Measure { get; set; }
        public decimal Price { get; set; }

        #endregion DataProperties

    }
}
