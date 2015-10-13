using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManualReset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manual Reset Event");
            //ManualResetEvent mre = new ManualResetEvent(true);
            AutoResetEvent are = new AutoResetEvent(true);
            for (int i = 0; i < 10; ++i)
            {
                ThreadPool.QueueUserWorkItem(SomeMethod, are);
                
            }
            Console.ReadKey();
        }

        static void SomeMethod(object obj)
        {
            EventWaitHandle ev = obj as EventWaitHandle;
            if(ev.WaitOne(10))
            {
                Console.WriteLine("Stream {0} managed", Thread.CurrentThread.ManagedThreadId);
                ev.Reset();
            }
            else
                Console.WriteLine("Stream {0} late" , Thread.CurrentThread.ManagedThreadId);
        }
    }
}
