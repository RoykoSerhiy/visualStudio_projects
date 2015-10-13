using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace EventDemo
{
    class CountDown
    {
        public delegate void AlarmMe(string str);
        public event AlarmMe onAlarm;

        public void Count(int n)
        {
            for (int i = n; i >= 0; --i)
            {
                Thread.Sleep(500);
                if (i == 10)
                {
                    onAlarm("save your progect");
                }
                if(i == 4)
                {
                    onAlarm("you have 4 min to go out!!!!!!!!!");
                }
            }
        }
    }
    class Handler
    {
        public void Alarm(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main()
        {
            CountDown cd = new CountDown();
            Handler handler = new Handler();

            cd.onAlarm += handler.Alarm;
            cd.Count(100);
        }
    }
}
