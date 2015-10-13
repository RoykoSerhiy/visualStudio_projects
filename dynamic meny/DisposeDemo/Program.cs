using System;


namespace DisposeDemo
{
    class ClassWithFinalizer
    {
        System.Timers.Timer _sillyTimer;

        public ClassWithFinalizer()
        {
            _sillyTimer = new System.Timers.Timer(100);
            _sillyTimer.Elapsed +=
                (a, b) => Console.WriteLine("Still Alive");
            _sillyTimer.Start();
        }
        ~ClassWithFinalizer()
        {
            _sillyTimer.Stop();
            _sillyTimer.Dispose();
            Console.WriteLine("you killed me!!!");
        }
    }


    class Program
    {
        static void Main()
        {

            new ClassWithFinalizer();
            System.Threading.Thread.Sleep(1000);
            GC.Collect();

        }
    }
}
