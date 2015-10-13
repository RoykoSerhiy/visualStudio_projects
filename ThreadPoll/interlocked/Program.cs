using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace interlocked
{
    class Program
    {
        class InterLockedCounter
        {
            int field1;
            int filed2;

            public int Field1
            {
                get { return field1; }
            }
            public int Field2
            {
                get { return filed2; }
            }

            public void UpdateFields()
            {
                for (int i = 0; i < 1000000; ++i)
                {
                    Interlocked.Increment(ref field1);
                    if (field1 % 2 == 0)
                    {
                        Interlocked.Increment(ref filed2);
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            InterLockedCounter c = new InterLockedCounter();
            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(c.UpdateFields);
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; ++i)
                threads[i].Join();

            Console.WriteLine("Filed1: {0} , Field2: {1}\n\n", c.Field1, c.Field2);
        }
    }
}
