using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borg
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
           // int square_count = 0;
           // int a, b, c;
           // int area;
           // Console.WriteLine("Enter A");
           // a = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter B");
           // b = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter C");
           // c = Convert.ToInt32(Console.ReadLine());
           // if (c < a && c < b)
           // {
           //     area = a * b;
           //     int area2 = c *c;
           //     square_count = area / area2;
           //     int freeArea = area - (area2*square_count);
           //     Console.WriteLine(square_count + " Sqare in rectangle with area:" + area);
           //     Console.WriteLine(freeArea + "Free area");
           // }
           // else
           // {
           //     Console.WriteLine("C biggest than A and B");
           // }
            //1.2
          //  int start_deposit = 1000;
          //  int p;
          //  int month_in_year = 12;
          //  Console.WriteLine("Enter %  0 < % < 25");
          //  p = Convert.ToInt32(Console.ReadLine());
          //  if (p < 0 || p > 25)
          //  {
          //      Console.WriteLine("0 < p < 25");
          //  }
          //  else
          //  {
          //      int sum_of_procent = (start_deposit * p) / 100;
          //      int sum = start_deposit + sum_of_procent;
          //      float a = sum / month_in_year;
          //      float b = ;
          //      
          //      Console.WriteLine(b);
          //  }
            //2.2
            int[] myArr = new int[10] {-3 , 2 , 1 , -4 , -2 , -1 ,3 , 4 , 0 , 5 };
            Array.Sort(myArr);
            for (int i = 0; i < myArr.Length; ++i)
            {
                Console.WriteLine(myArr[i]);
            }
            //2.4

            //2.5
            //try
            //{
            //    string str = Console.ReadLine();
            //    char sym = Convert.ToChar(Console.ReadLine());
            //    int idx = str.LastIndexOf(sym);
            //    str.Remove(3);
            //
            //    Console.WriteLine(str);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //
        }
    }
}
