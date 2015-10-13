using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace interlockedGood
{
    class Program
    {
        //class MonitorLockCounter
        //{
        //    int field1;
        //    int field2;
        //
        //    public int Field1 { get { return field1; } }
        //    public int Field2 { get { return field2; } }
        //
        //    public void UpdateFields()
        //    {
        //        for (int i = 0; i < 1000000; ++i)
        //        {
        //            Monitor.Enter(this);
        //            try
        //            {
        //                ++field1;
        //                if (field1 % 2 == 0)
        //                    ++field2;
        //            }
        //            finally
        //            {
        //                Monitor.Exit(this);
        //            }
        //        }
        //    }
        //}

        class MonitorLockCounter
        {
            int field1;
            int field2;

            public int Field1 { get { return field1; } }
            public int Field2 { get { return field2; } }

            public void UpdateFields()
            {
                for (int i = 0; i < 1000000; ++i)
                {
                    lock (typeof(MonitorLockCounter))
                    {
                        ++field1;
                        if (field1 % 2 == 0)
                            ++field2;
                    }
                }
            }
        }




        static void Main(string[] args)
        {
            MonitorLockCounter c = new MonitorLockCounter();
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
