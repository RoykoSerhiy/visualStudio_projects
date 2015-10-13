using System;
delegate void DoubleOp(double x);

namespace Multicasting
{
    class MathOperations
    {
        public static void MultiplyBy2(double val)
        {
            double res = val * 2;
            Console.WriteLine("Multyply {0} by 2 is {1,0:F2}:", val, res);
        }
        public static void Square(double val)
        {
            double res = val * val;
            Console.WriteLine("Square {0} by 2 is {1,0:F2}:", val, res);
        }
    }
    

    class Program
    {
        static void ProcessAndDisplay(DoubleOp action, double val)
        {
            action(val);
        }
        static void Main()
        {

            DoubleOp op = new DoubleOp(MathOperations.MultiplyBy2);
            op += new DoubleOp(MathOperations.Square);

            ProcessAndDisplay(op, 2.0);
            ProcessAndDisplay(op, 17.5);
            ProcessAndDisplay(op, 2.5454);

        }
    }
}
