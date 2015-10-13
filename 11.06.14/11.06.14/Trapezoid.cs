using System;


namespace ShapeClases
{
    class Trapezoid : Shape
    {
          private  double a, b, c, d, h;
          public Trapezoid(double _a, double _b, double _c, double _d, double _h)
          {
              a = _a;
              b = _b;
              c = _c;
              d = _d;
              h = _h;
              SetPerimetr();
              SetArea();
          }
          public void SetPerimetr()
          {
              Perimeter = a + b + c + d;
          }
          public void SetArea()
          {
              Area = (a+b/2)*h;
          }
          public override string ToString()
          {
              return string.Format("trapezoid with a {0,0:F2}; b{1,0:F2}; c{2,0:F2}; d{3,0:F2};h{4,0:F2} "+" perimetr{5,0:F2}; area{6,0:F2}",a,b,c,d,h,Perimeter , Area);
          } 
    }
}
