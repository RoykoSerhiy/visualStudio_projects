using System;

namespace kalk
{
    class kalk
    {
        public double N1, N2;

        public kalk(double n1, double n2)
        {
            N1 = n1;
            N2 = n2;
        }

        public void Plus(double n1, double n2)
        {
            double n3 = n1 + n2;
            Console.WriteLine(n1+"+"+n2+"="+n3);
        }
        public void Minus(double n1, double n2)
        {
            double n3 = n1 - n2;
            Console.WriteLine(n1 + "-" + n2 + "=" + n3);
        }
        public void Multi(double n1, double n2)
        {
            double n3 = n1 * n2;
            Console.WriteLine(n1 + "*" + n2 + "=" + n3);
        }
        public void Div(double n1, double n2)
        {
            double n3 = n1 / n2;
            Console.WriteLine(n1 + "/" + n2 + "=" + n3);
        }
    }
}
