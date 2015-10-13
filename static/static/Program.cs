using System;
using System.Diagnostics;

namespace StaticMetod
{
    class Test1
    {
        int _a;
        int _b;
        int _c;

        public void X()
        {
            this._a++;
            this._b++;
            this._c++;
        }
    }
    class Test2
    {
       static int _a;
       static int _b;
       static int _c;

        public void X()
        {
            _a++;
            _b++;
            _c++;
        }
    }

    class Program
    {

        const int _max = 200000000;
        static void Main(string[] args)
        {

            Test1 test1 = new Test1();
            
            Test2 test2 = new Test2();

            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < _max; ++i)
            {
                test1.X();
                test1.X();
                test1.X();
                test1.X();
                test1.X();
            }
            s1.Stop();
            Console.WriteLine(  (((double)s1.Elapsed.TotalMilliseconds / 1000)).ToString("0.00") + " s");



            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < _max; ++i)
            {
                test2.X();
                test2.X();
                test2.X();
                test2.X();
                test2.X();
            }
            s2.Stop();
            Console.WriteLine((((double)s2.Elapsed.TotalMilliseconds / 1000)).ToString("0.00") + " s");
            
        }

    }
}
