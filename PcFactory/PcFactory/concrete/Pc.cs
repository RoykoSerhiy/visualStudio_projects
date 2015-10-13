using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcFactory.concrete
{
    public class Pc
    {
        public Box Box { get; set; }
        public Processor Processor { get; set; }
        public MainBoard MainBoard { get; set; }
        public Hdd Hdd { get; set; }
        public Memory Memory { get; set; }
    }
}
