using System;


namespace ShapeClases
{
    class Diamond : Shape
    {
        private double _d1, _d2, _a;

        public Diamond()
        {
            _d1 = _d2 = Area = Perimeter = 0;
            SetArea();
            SetPerimeter();
        }

        public Diamond(double d1, double d2)
        {
            _d1 = d1;
            _d2 = d2;
            _a = Math.Sqrt((d1 / 2) * (d1 / 2) + (d2 / 2) * (d2 / 2));
            SetArea();
            SetPerimeter();
        }

        void SetArea()
        {
            Area = Math.Sqrt((_d1 * _d1) * (_d2 * _d2)) / 2;
        }

        void SetPerimeter()
        {
            Perimeter = _a + _a + _a + _a;
        }

        public override string ToString()
        {
            return string.Format("[Diamond] a {0,0:F2}; P = {1,0:F2}; A = {2,0:F2}", _a, Perimeter, Area);
        }
    }
}
