using System;


namespace staticConstructorDemo
{

    class Bus
    {
        static readonly DateTime globalStartTime;
        int RouteNumber { set; get; }


        static Bus()
        {
            globalStartTime = DateTime.Now;
            Console.WriteLine("Static ctr set globalStratTime to {0}", 
                globalStartTime.ToLongTimeString());
        }
        public Bus(int routeNum)
        {
            RouteNumber = routeNum;
            Console.WriteLine("Bus #{0} was created" , RouteNumber);
        }

        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;
            Console.WriteLine("{0} is starting its route {1:N2} minutes after gloabal start time{2}",
                this.RouteNumber, elapsedTime.TotalMilliseconds, globalStartTime.ToShortTimeString());
        }
    }
    class Program
    {

        
        static void Main(string[] args)
        {
            Bus bus1 = new Bus(47);
            Bus bus2 = new Bus(51);



            bus1.Drive();
            System.Threading.Thread.Sleep(25);

            bus2.Drive();


            
        }
    }
}
