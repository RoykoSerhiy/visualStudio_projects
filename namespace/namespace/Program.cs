using System;
using SevenWonders;

namespace Main
{
    class Program
    {
        static void Main()
        {
            Wonder01 w1 = new Wonder01();
            Wonder02 w2 = new Wonder02();
            Wonder03 w3 = new Wonder03();
            Wonder04 w4 = new Wonder04();
            Wonder05 w5 = new Wonder05();
            Wonder06 w6 = new Wonder06();
            Wonder07 w7 = new Wonder07();

            Console.WriteLine(w1.Title);
            Console.WriteLine(w2.Title);
            Console.WriteLine(w3.Title);
            Console.WriteLine(w4.Title);
            Console.WriteLine(w5.Title);
            Console.WriteLine(w6.Title);
            Console.WriteLine(w7.Title);
            
        }
    }
}
