using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcFactory.concrete
{
    public class MainBoard
    {
        public List<Adapter> CreateAdapter(int num)
        {
            List<Adapter> adapters = new List<Adapter>();
            for (int i = 0; i < num; ++i)
            {
                adapters.Add(new Adapter());
            }
            return adapters;
        }
    }
    public class MSIMainboard : MainBoard
    {
    }
    public class AsusMainBoard : MainBoard
    {
    }
}
