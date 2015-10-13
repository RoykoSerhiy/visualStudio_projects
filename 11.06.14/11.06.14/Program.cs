using System;


namespace ShapeClases
{


    class Program
    {
        static void Main()
        {

            Shape r1 = new Round(15.0);
            Console.WriteLine(r1.ToString());

            Shape k1 = new Ellipse(15.0,7.0);
            Console.WriteLine(k1.ToString());

            Shape a1 = new Diamond(10.0 , 2.0);
            Console.WriteLine(a1.ToString());

            Shape b1 = new Parallelogram(10.0 , 7.0 , 3.0);
            Console.WriteLine(b1.ToString());

            Shape c1 = new Rectangle(10.0 , 5.0);
            Console.WriteLine(c1.ToString());

            Shape d1 = new Square(10.0);
            Console.WriteLine(d1.ToString());

            Shape f1 = new Triangle(10.0 ,5.0,7.0);
            Console.WriteLine(f1.ToString());

            Shape trap1 = new Trapezoid(5, 6, 7, 8, 10);
            Console.WriteLine(trap1.ToString());

            try
            {
                Shape tr1 = new Triangle(5.0, 4.0, 10.0);
                Console.WriteLine(tr1.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
