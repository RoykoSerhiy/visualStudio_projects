using System;

namespace ShapeClases
{
    class Rectangle : Shape
    {
        private double _a, _b;

        public Rectangle()
        {
            _a = _b = Area = Perimeter = 0;
            SetPerimeter();
            SetArea();
        }

        void SetPerimeter()
        {
            Perimeter = 2 * _a + 2 * _b;
        }

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;

            SetPerimeter();
            SetArea();
        }

        void SetArea()
        {
            Area = _a * _b;
        }

        public override string ToString()
        {
            return string.Format("[Rectangle] a {0,0:F2}; b {1,0:F2}" +
                                 "; P = {2,0:F2}; A = {3,0:F2}", _a, _b, Perimeter, Area);
        }
    }
}
