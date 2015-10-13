using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main()
        {
            int[] scores = { 90,71,81,93,75,82};
            int highScoreCount = scores.Where(n => n > 80).Count();
            Console.WriteLine(highScoreCount);
            Console.WriteLine();
        }
    }
}
