using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<object> o = new List<object>();
            o.Add(new Exception());
            o.Add(3.44);
            o.Add(new List<object>());
            
            ParameterizedThreadStart start = new ParameterizedThreadStart(Method1);
            Thread t = new Thread(start);
            t.Start((object) o);
        }
        static void Method1(object o)
        {
            List<object> obj = (List<object>) o;
            
            foreach(object ob in obj)
            {
                Console.WriteLine(ob.ToString());
            }
        }
    }
}
