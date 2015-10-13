using System;


namespace ShapeClases
{
    class Round : Shape
    {
        private double radius;
        void SetPerimeter()
        {
            Perimeter = 2 * (Math.PI*radius) ;
        }
        void SetArea()
        {
            Area = Math.PI * (radius * radius);
        }
        public Round(double _radius)
        {
            radius = _radius;
            SetPerimeter();
            SetArea();
        }
        public Round(decimal _diametr)
        {
            radius = (double)_diametr/2;
            SetPerimeter();
            SetArea();
        }
        public override string ToString()
        {
            return string.Format("Round with radius{0,0:F2}" + "; P = {1,0:F2}; A = {2,0:F2}", radius, Perimeter, Area);
        }
    }
}
