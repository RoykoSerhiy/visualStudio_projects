using System;
using System.Collections.Generic;


namespace GenericDemo
{
    class Program
    {
        class Poinr2D<T>
        {
            T _x;
            T _y;

            public T X
            {
                get { return _x; }
                set { _x = value; }
            }
            public T Y
            {
                get { return _y; }
                set { _y = value; }
            }

            public Poinr2D(T x, T y)
            {
                _x = x; _y = y;
            }
            public Poinr2D()
            {
                _x = default(T);
                _y = default(T);
            }
            public override string ToString()
            {
                return "x = "+ X + ";" + "y = "+ Y + ";";
            }


        }
        static void Main()
        {
            Poinr2D<int> p1 = new Poinr2D<int>(11, 12);
            Console.WriteLine(p1);

            Poinr2D<double> p2 = new Poinr2D<double>(11.1, 12.5);
            Console.WriteLine(p2);

            Poinr2D<string> p3 = new Poinr2D<string>("20", "50-10");
            Console.WriteLine(p3);
        }
    }
}
