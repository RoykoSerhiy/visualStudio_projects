using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    
    public class Product
    {
        double price;
        public string Title { set; get; }
        public string Producer { set; get; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price < 0");
                }
                else
                {
                    price = value;
                }
            }
        }
        public Product()
        {
            Title = "Unknown";
            Producer = "Unknown";
            Price = 0.0;
        }
        public override string ToString()
        {
            return Title+"; Виробник:" + Producer + "; Вартість: "+Price;
        }
    }
}
