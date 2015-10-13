using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcFactory.concrete
{
    public class OfficePcFactory : IPcFactory
    {
        public Box CreateBox()
        {
            return new GoldBox();
        }
        public Processor CreateProcessor()
        {
            return new AmdProcessor();
        }
        public MainBoard CreateMainBoard()
        {
            return new AsusMainBoard();
        }
        public Hdd CreateHdd()
        {
            return new LGHdd();
        }
        public Memory CreateMemory()
        {
            return new DDRMemory();
        }
    }
}
