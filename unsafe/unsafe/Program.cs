using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_code
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int param = 2;
            Pow(&param , 4);
            Console.WriteLine("value is {0}" , param);
        }
        unsafe static void Pow(int *x , int y)
        {
            int z = *x;
            for (int i = 1; i < y; ++i)
            {
                *x *= z;
            }
        }
    }
}
