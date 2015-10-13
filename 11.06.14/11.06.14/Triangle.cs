using System;

namespace ShapeClases
{
    class Triangle : Shape
    {
        private double _a, _b, _c;

        public Triangle()
        {
            _a = _b = _c = Area = Perimeter = 0;
        }

        void SetPerimeter()
        {
            Perimeter = _a + _b + _c;
        }
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            if (_a >= _b + _c || _b >= _a + _c || c >= _a + _b || _a <= 0 || _b <= 0 || _c <= 0)
            {
                throw new WrongDataException("Wrong data user");
            }
           
            SetPerimeter();
            SetArea();
        }
        public Triangle(double a, double b, decimal angl)
        {
            _a = a;
            _b = b;
            _c = Math.Sqrt(_a * _a + _b * _b - 2 * _a * _b * Math.Cos((double)angl * Math.PI / 180));
           
            SetPerimeter();
            SetArea();
        }
        public Triangle(double a, decimal angl1, decimal angl2)
        {
            _a = a;
            decimal angl = 180 - angl1-angl2;
            _b = Math.Sin((double)angl1) * _a / Math.Sin((double)angl);
            _c = Math.Sin((double)angl2) * _a / Math.Sin((double)angl);
            SetPerimeter();
            SetArea();
        }

        
        void SetArea()
        {
            double p = Perimeter / 2;
            Area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public override string ToString()
        {

            return string.Format("[Triangle] a {0,0:F2}; b{1,0:F2}; c{2,0:F2}" + "; P = {3,0:F2}; A = {4,0:F8}", _a, _b, _c, Perimeter, Area);
        }
    }
}
