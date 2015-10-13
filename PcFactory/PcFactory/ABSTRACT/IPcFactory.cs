using PcFactory.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcFactory.ABSTRACT
{
    public interface IPcFactory
    {
        Box CreateBox();
        Processor CreateProcessor();
        MainBoard CreateMainBoard();
        Hdd CreateHdd();
        Memory CreateMemory();
    }
}
