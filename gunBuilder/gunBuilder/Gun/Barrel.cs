using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunBuilder.Gun
{
    public class Barrel
    {
        public string model;
        public decimal cal { get; set; }
        public decimal weight { get; set; }
        public string matherial { get; set; }

        public string ModelProperty
        {
            get { return model; }
            set { model = value; }
        }
    }
}
