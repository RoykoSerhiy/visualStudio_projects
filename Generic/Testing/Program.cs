using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


namespace Testing
{
    class Program
    {
        static void Main()
        {
            Test();
        }


        static void Test()
        {
            const int amount = 10000000;

            using (new OperationTimer("List"))
            {
                List<int> list = new List<int>(amount);
                for (int i = 0; i < amount; ++i)
                {
                    list.Add(i);
                    int x = list[i];
                }
                list = null;
            }
            using (new OperationTimer("ArrayList"))
            {
                ArrayList arrList = new ArrayList();
                for (int i = 0; i < amount; ++i)
                {
                    arrList.Add(i);
                    int x = (int)arrList[i];
                }
                arrList = null;
            }
        }

       
    }
    internal sealed class OperationTimer : IDisposable
    {
        Int64 _startTime;
        string _text;
        int _count;
        public OperationTimer(string text)
        {
            _text = text;
            _count = GC.CollectionCount(0);
            _startTime = Stopwatch.GetTimestamp();
        }

        static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        public void Dispose()
        {
            Console.WriteLine("{0,6:0.00} s. (GC = {1,3}) {2}"
                ,(Stopwatch.GetTimestamp()- _startTime)/(double)Stopwatch.Frequency,
                GC.CollectionCount(0)- _count , _text);
        }
     
    }
}
