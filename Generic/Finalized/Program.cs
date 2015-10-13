using System;
using System.Collections.Generic;


namespace Finalized
{
    class FinalizeObj
    {
        public int Id { get; set; }
        public FinalizeObj(int id)
        {
            Id = id;
        }
        ~FinalizeObj()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
           // Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Об єкт № {0} destroyed", Id);
           // Console.Beep();
        }
    }
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            FinalizeObj[] obj = new FinalizeObj[100];
            for (int i = 0; i < 100; ++i)
            {
                obj[i] = new FinalizeObj(i + 1);
            }


        }
    }
}
