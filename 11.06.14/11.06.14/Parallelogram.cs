using System;

namespace ShapeClases
{
    class Parallelogram : Shape
    {
        private double a, b;

        public Parallelogram(double a, double b, double heightToSmallerSide)
        {
            this.a = a;
            this.b = b;

            Perimeter = 2 * (a + b);

            if (a < b)
            {
                Area = a * heightToSmallerSide;
            }
            else
            {
                Area = b * heightToSmallerSide;
            }
        }

        public Parallelogram(double a, double b, decimal angle)
        {
            this.a = a;
            this.b = b;

            Perimeter = 2 * (a + b);
            Area = a * b * Math.Sin((double)angle * Math.PI / 180);
        }

        public override string ToString()
        {
            return "Parallelogram: A = " + a + " B = " + b + " Perimetr = " + Perimeter + " Area = " + Area;
        }
    }
}
