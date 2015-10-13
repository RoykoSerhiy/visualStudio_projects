using System;
using System.Collections.Generic;
namespace conteiners
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List = new List<int>();
            List.Add(2);
            List.Add(3);
            List.Add(4);
            List.Add(5);
            foreach(int l in List)
            {
                Console.WriteLine(l);
            }
            List<bool> List2= new List<bool>();
            List2.Add(true);
            List2.Add(false);
            List2.Add(true);
            List2.Add(true);
            List2.Clear();
            Console.WriteLine(List2.Count);

        }
    }
}
