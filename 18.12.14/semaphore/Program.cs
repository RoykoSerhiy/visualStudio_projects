using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace semaphore
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Semaphore s = new Semaphore(3 , 3 , "My_SEMAPHORE");
            for (int i = 0; i < 6; ++i)
                ThreadPool.QueueUserWorkItem(SomeMethod, s);
            
            Console.ReadKey();
            
        }
        static void SomeMethod(object obj)
        {
            Semaphore s = obj as Semaphore;
            bool stop = false;

            while (!stop)
            {
                if (s.WaitOne(500))
                {
                    try
                    {
                        Console.WriteLine("Stream {0} blocked",
                            Thread.CurrentThread.ManagedThreadId);
                        Thread.Sleep(2000);
                    }
                    finally
                    {
                        stop = true;
                        s.Release();
                        Console.WriteLine("stream {0} unblocked",
                            Thread.CurrentThread.ManagedThreadId
                            );
                    }
                }
                else
                    Console.WriteLine("Timeout for stream {0} end. Wait",
                        Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
