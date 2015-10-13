using System;
using System.Collections.Generic;
using System.Linq;


namespace points_coords
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
           
        }
        class PointInPlane
        {
            Poinr2D<double> p1 = new Poinr2D<double>();
            Poinr2D<double> p2 = new Poinr2D<double>();
            int x1 , y1;
            int x2 , y2;
            public PointInPlane(Poinr2D<double> _p1, Poinr2D<double> _p2)
            {
                p1.X = _p1.X;
                p1.Y = _p1.Y;
                p2.X = _p2.X;
                p2.Y = _p2.Y;
            }
            public PointInPlane(int _x1,int _y1,int _x2,int _y2)
            {
                x1 = _x1;
                y1 = _y1;
                x2 = _x2;
                y2 = _y2;
            }
            public override string ToString()
            {
                return "point1 x: " + p1.X + " point1 y: " + p1.Y + " point2 x: " + p2.X + " point2 y: " + p2.Y + "\n"
                    +" x1: "+x1+" y1: "+y1+" x2: "+x2+" y2: "+y2+" \n";
            } 
            
        }
        static void Main()
        {
            Poinr2D<double> p1 = new Poinr2D<double>(2.5, 2.2);
            Poinr2D<double> p2 = new Poinr2D<double>(3.5, 7.2);

            PointInPlane pin = new PointInPlane(p1, p2);
            Console.WriteLine(pin.ToString());
            PointInPlane pin2 = new PointInPlane(7 , 4, 6, 8);
            Console.WriteLine(pin2.ToString());

        }
    }
}
