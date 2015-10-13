using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            cki = Console.ReadKey(true);
            do
            {
            if (Console.KeyAvailable == true)
            {
                
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.LeftArrow)
                    {
                        Console.WriteLine("Left");
                    }
                    else
                        if (cki.Key == ConsoleKey.RightArrow)
                        {
                            Console.WriteLine("Right");
                        }
               
                

            }
            } while (cki.Key != ConsoleKey.Q);
        }
    }
}
