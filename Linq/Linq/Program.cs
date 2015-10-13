using System;
using System.Linq;
using System.Collections.Generic;

namespace IEnumerable
{
    class Program
    {
        static void Main()
        {
            IEnumerable<int> res = 
                from value in Enumerable.Range(5, 10) select value;

            foreach (int n in res)
            {
                Console.WriteLine(n);
            }
            List<int> list = res.ToList();
            int[] array = res.ToArray();

            Display(new List<double> { 1.1, 2.2, 3.3, 4.4, 5.5 });
        }
        static void Display(IEnumerable<double> args)
        {
            foreach (double val in args)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
