using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadbreak
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            t.Start();
            Console.WriteLine("Press any key to stop stream");
            Console.ReadKey();
            t.Suspend();
            Console.WriteLine("Stream stoped");
            Console.WriteLine("Press any key to continue stream");
            Console.ReadKey();
            t.Resume();
        }

       static void Method()
        {
            for (int i = 0; i < 100; ++i)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
