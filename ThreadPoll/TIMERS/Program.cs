using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TIMERS
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer(TimerMethod, null, 0, 1000);
            Console.WriteLine("Main thread {0} continue...", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(10000);
            t.Dispose();
        }
        static void TimerMethod(Object obj)
        {
            Console.WriteLine("Stream {0} : {1}" , Thread.CurrentThread.ManagedThreadId
                ,DateTime.Now);
        }
    }
}
