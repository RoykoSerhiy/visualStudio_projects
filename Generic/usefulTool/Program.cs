using System;
using System.Collections.Generic;


namespace usefulTool
{
    class Program
    {
        class UserInfo
        {
            string Name { set; get; }
           int Age { set; get; }
           public UserInfo(string name, int age)
           {
               Name = name;
               Age = age;
           }
        }

        static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("System information:\n"+
                "----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Operation System:{0},"+" .NET version:{1}",
                Environment.OSVersion,
                Environment.Version);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nGarbage Collector Info:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Amount of bytes in the Heap: {0}",
                GC.GetTotalMemory(false));
            Console.WriteLine("Max Generation: {0}", GC.MaxGeneration + 1);
            UserInfo user1 = new UserInfo("Serhiy", 18);
            Console.WriteLine("Generation user1: " + GC.GetGeneration(user1));
            for (int i = 0; i < 5000; ++i)
            {
                UserInfo user = new UserInfo("Aaaaaa" , 15);
            }
            Console.WriteLine("Amount of bytes in the Heap aftrr for: {0}",
              GC.GetTotalMemory(false));
            GC.Collect(0 , GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\nGarbage Collecting:\n");
            Console.WriteLine("and now Generation user1: "+GC.GetGeneration(user1));
            Console.WriteLine("Amount of bytes in the Heap: {0}",
               GC.GetTotalMemory(false));
           

        }
    }
}
