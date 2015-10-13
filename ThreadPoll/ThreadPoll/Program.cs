using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread: ");
            Random r = new Random();
            for (int i = 0; i < 10; ++i)
            {
                ThreadPool.QueueUserWorkItem(WorkingElementMethod, 10);
            }
            Console.WriteLine("Main thread: run another task");
            Thread.Sleep(1000);
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        public static void WorkingElementMethod(object state)
        {
            Console.WriteLine("\tstram: {0} state = {1}",
                Thread.CurrentThread.ManagedThreadId, state);
            Thread.Sleep(1000);
        }
    }
}
