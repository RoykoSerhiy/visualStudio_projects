using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    class Program
    {
         //public static ThreadStart threadStart = new ThreadStart(Method);
        public static int Count_1 = 0;
        public static int Count_2 = 0;
        static void Main(string[] args)
        {
            

            ParameterizedThreadStart start = new ParameterizedThreadStart(Method);
            Thread t1 = new Thread(start);
            t1.Priority = ThreadPriority.Highest;
            t1.Start((object)"One");
            ParameterizedThreadStart start2 = new ParameterizedThreadStart(Method2);
            Thread t2 = new Thread(start2);
            t2.Priority = ThreadPriority.Lowest;
            t2.Start((object)"\t\tTwo");
            //Thread thread = new Thread(threadStart);
            //thread.Start();
            //for (int i = 0; i < 100; ++i)
            //{
            //    Console.WriteLine("This is MAIN\n");
            //}
        }
        public static void Method(object a)
        {
            string ID = (string)a;
            Count_1++;
            for (int i = 0; i < 100;i++)
            {
                
                Console.WriteLine(ID);

            }
            Console.WriteLine("Count Method: " + Count_1);
            // for (int i = 0; i < 100; ++i)
            // {
            //     Console.WriteLine("\t\tThis is Thread!!!\n");
            // }
        }
        public static void Method2(object a)
        {
            string ID = (string)a;
            Count_2++;
            for (int i = 0; i < 100; i++)
            {
                
                Console.WriteLine(ID);
            }
            Console.WriteLine("Count Method2: " + Count_2);
            // for (int i = 0; i < 100; ++i)
            // {
            //     Console.WriteLine("\t\tThis is Thread!!!\n");
            // }
        }
    }
}
