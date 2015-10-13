using System;
using System.Collections.Generic;

namespace GenericDelegats
{
    class Program
    {
        static void Print(int n)
        {
            Console.WriteLine(n);
        }
        static bool IsNegative(int n)
        {
            return n < 0;
        }
        static void Main()
        {
            List<int> list = new List<int>(10);
            Random rand = new Random();
            for (int i = 0; i < 10; ++i)
            {
                list.Add(rand.Next(20) - 10);

            }
            Console.WriteLine("Colection: ");
            list.ForEach(new Action<int>(Print));
            List<int> listNegative =
                list.FindAll(new Predicate<int>(IsNegative));

            listNegative.ForEach(new Action<int>(Print));
        }
    }
}
