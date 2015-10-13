using System;


namespace SimpleDelegats
{
    

    class Program
    {

        delegate double DoubleOp(double x);

        static void ProcessAndDisplay(DoubleOp action , double val)
        {
            double res = action(val);
            Console.WriteLine("Value is {0}, action is {1 , 0:F2}", val , res);
        }

        static void Main()
        {
            DoubleOp multyBy2 = delegate(double val) { return val * 2; };
                    DoubleOp square = delegate(double val){return val * val;};
                    DoubleOp[] operations = { multyBy2, square };
            for (int i = 0; i < operations.Length; ++i)
            {
                Console.WriteLine("using operations[{0}]:", i);
                ProcessAndDisplay(operations[i], 2.0);
                ProcessAndDisplay(operations[i], 7.95);
                ProcessAndDisplay(operations[i], 1.12121);
            }
        }
    }
}
