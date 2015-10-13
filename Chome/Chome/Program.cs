using System;


namespace Chome
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////1.kvadraty//////////////////
            //int a, b, c;
            //Console.WriteLine("enter a:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter b:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter c:");
            //c = Convert.ToInt32(Console.ReadLine());
            //if(c>a||c>b)
            //{
            //    Console.WriteLine("ne vlize ni odun kvadrat");
            //}
            ///////////////2.bank/////////////////////
            //int nach_vklad = 1000;
            //Console.WriteLine("Enter procent 0<p<25");
            //double s;
            //int k = 0;
            //double p = Convert.ToDouble(Console.ReadLine());
            //if (p < 0 || p > 25)
            //{
            //    Console.WriteLine("!!!ERROR!!!: 0<p<25 ");
            //}
            //else
            //{
            //    s = nach_vklad + (nach_vklad *(p/100));
            //    Console.WriteLine("Sum:" + s);
                
               
            //}
            //////////////3.chisla////////////////////
            int a, b;
            Console.WriteLine("enter a and b (a<b)");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a>b a skazano b>a");
            }
            else
            {
                for (int i = a; i <= b; ++i)
                {

                    for (int j = 0; j < i; ++j)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
