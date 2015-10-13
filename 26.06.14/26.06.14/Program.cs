using System;
using System.Collections.Generic;
using System.Linq;

namespace _26._06._14
{
    class Program
    {
        delegate int MathDelegate(int x , int y);

        static void Main()
        {
            Console.WriteLine(Sum(33,22));
            Console.WriteLine(Sub(33, 22));

            //MathDelegate md = new MathDelegate(Sum);
            MathDelegate md = Sum;
            Console.WriteLine(md(33 , 22));
            md = Sub;
            Console.WriteLine(md(33 ,22));
            //
            md = delegate(int x, int y)
            {
                return x * x + y * y;
            };
            Console.WriteLine(md(3, 4));

            md = (x, y) => (x * x + y * y);
            Console.WriteLine(md(3, 4));


        }


        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
