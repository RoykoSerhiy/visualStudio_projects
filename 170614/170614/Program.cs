using System;


namespace _170614
{

    class Circle
    {
        public double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public void PrintRadius()
        {
            Console.WriteLine("Radius: {0,7:N3}", _radius);

        }
        public void PrintDiametr()
        {
            double diameter = 2 * _radius;
            Console.WriteLine("Diameter: {0,7:N3}", diameter);
        }
        public void PrintLength()
        {
            double length = 2 * Math.PI * _radius;
            Console.WriteLine("Length: {0,7:N3}", length);
        }
        public void PrintSqare()
        {
            double square = Math.PI * _radius * _radius;
            Console.WriteLine("Square: {0,7:N3}", square);
        }
    }
    delegate void PrintInfo();
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(5);

            PrintInfo printInfo = new PrintInfo(circle.PrintRadius);
            Console.WriteLine("Delegate was init by one method "+"PrintRadius()");
            printInfo();

            printInfo += circle.PrintDiametr;
            printInfo += circle.PrintLength;
            printInfo += circle.PrintSqare;

            Console.WriteLine();
            printInfo();

            PrintInfo printInfo1 = circle.PrintSqare;
            printInfo -= printInfo1;

            Console.WriteLine();
            printInfo();

            printInfo = printInfo + printInfo1 - new PrintInfo(circle.PrintRadius)
            - new PrintInfo(circle.PrintDiametr);

            Console.WriteLine();
            printInfo(); 


        }
    }
}
