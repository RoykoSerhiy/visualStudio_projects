using PcFactory.ABSTRACT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcFactory.concrete
{
    public class HomePcFactory : IPcFactory
    {
        public Box CreateBox()
        {
            return new SilverBox();
        }
        public Processor CreateProcessor()
        {
            return new IntelProcessor();
        }
        public MainBoard CreateMainBoard()
        {
            return new MSIMainboard();
        }
        public Hdd CreateHdd()
        {
            return new SamsungHdd();
        }
        public Memory CreateMemory()
        {
            return new DDR2Memory();
        }
    }
}
