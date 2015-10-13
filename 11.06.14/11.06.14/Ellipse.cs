using System;
namespace ShapeClases
{
    class Ellipse : Shape
    {
        private double _big_axis, _low_axis;

        public Ellipse()
        {
            _big_axis = _low_axis = 0;
            SetPerimeter();
            SetArea();
        }

        public Ellipse(double Big_axis, double Low_axis)
        {
            _big_axis = Big_axis;
            _low_axis = Low_axis;
            SetPerimeter();
            SetArea();
        }

        void SetPerimeter()
        {
            Perimeter = 2 * Math.PI * Math.Sqrt(((_big_axis * _big_axis) + (_low_axis * _low_axis)) / 2);
        }

        void SetArea()
        {
            Area = Math.PI * _big_axis * _low_axis;
        }

        public override string ToString()
        {
            return string.Format("[Ellipce] big axis {0,0:F2};  low axis {1,0:F2};" +
                "; P= {2,0:F2}; S={3,0:F2}", _big_axis, _low_axis, Perimeter, Area);
        }
    }
}
