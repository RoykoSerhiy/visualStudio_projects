using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linq2
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 5, 4, 1, 3, 8, 9, 6, 7, 2, 0 };
            var lowNums =
                from n in numbers
                where n < 5
                select n;
            Console.WriteLine("numbers < 5: ");

            foreach (var x in lowNums)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            int[] arr = lowNums.ToArray();
            Console.WriteLine(arr[2]);
            //2.

            var numPlusOne = from n in numbers
                             select ++n;
            foreach (var x in numPlusOne)
            {
                Console.Write(x + " ");
            }

        }

       
    }
}
