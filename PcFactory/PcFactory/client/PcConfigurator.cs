using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcFactory.concrete;
using PcFactory.ABSTRACT;


namespace PcFactory.client
{
    public class PcConfigurator
    {
        public IPcFactory PcFactory { get; set; }

        public void Configure(Pc pc)
        {
            pc.Box = PcFactory.CreateBox();
            pc.MainBoard = PcFactory.CreateMainBoard();
            pc.Processor = PcFactory.CreateProcessor();
            pc.Hdd = PcFactory.CreateHdd();
            pc.Memory = PcFactory.CreateMemory();
        }
    }
}
