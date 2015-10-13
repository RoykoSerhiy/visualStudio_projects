using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _18._12._14
{
    class Program
    {
       static object a = new object();
       static object b = new object();

        static void Main(string[] args)
        {
            ThreadStart s1 = new ThreadStart(M1);
            ThreadStart s2 = new ThreadStart(M2);

            Thread t1 = new Thread(s1);
            Thread t2 = new Thread(s2);

            t1.Start();
            t2.Start();
            
            Console.WriteLine("end");
        }
       static void M1()
        {
            lock (a)
            {
                Thread.Sleep(100);
                lock (b)
                {
                    Console.WriteLine("method 1");
                }
            }
        }
       static void M2()
        {
            lock (b)
            {
                Thread.Sleep(100);
                lock (a)
                {
                    Console.WriteLine("method 2");
                }
            }
        }
    }
}
