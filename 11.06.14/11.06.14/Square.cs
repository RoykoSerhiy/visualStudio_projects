using System;

namespace ShapeClases
{
    class Square : Shape
    {
        private double _a;

        public Square()
        {
            _a = Area = Perimeter = 0;
            SetPerimeter();
            SetArea();
            
        }



        public Square(double a)
        {
            _a = a;
            SetPerimeter();
            SetArea();
            
        }

        void SetPerimeter()
        {
            Perimeter = _a * 4;
        }

        void SetArea()
        {
           
            Area =  _a*_a;
        }

        public override string ToString()
        {
            return string.Format("[Square] a= {0,0:F2}; P= {1,0:F2}; A={2,0:F2}", _a, Perimeter, Area);
        }
    }
}
