using System;
using System.Collections.Generic;
using System.Linq;


namespace Pointthreed
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
    class Point3D<T> : Poinr2D<T>
    {
        T _z;

        public T Z
        {
            get { return _z; }
            set { _z = value; }
        }
        public Point3D(T x ,T y,T z) : base(x , y)
        {
            _z = z;
        }
        public override string ToString()
        {
            return "x = " + X + ";" + "y = " + Y + ";z = "+ Z +";";
        }

    }
    class Program
    {
        static void Main()
        {
            Point3D<int> p = new Point3D<int>(3,8,2);
            Console.WriteLine(p.ToString());
        }
    }
}
