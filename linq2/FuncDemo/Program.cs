using System;
using System.Collections.Generic;
using System.Linq;


namespace FuncDemo
{
    class Program
    {
        //delegate string ConvertMethod(string inString);
        static void Main()
        {
          //  ConvertMethod method = UpperCaseString;

            Func<string, string> method = UpperCaseString;

            //string str = "hello world";
            //Console.WriteLine(method(str));


            //2.Func

            Func<int, int> func1 = x => x + 105;
            Func<int, int> func2 = x => { return x + 100; };
            Func<int, int> func3 = (int x) => x + 200;
            Func<int, int> func4 = (int x) => { return x + 200; };
            Func<int, int, int> func5 = (x, y) => { return x + y; };
            Func<string, string> func6 = (string s) => { return ("Hello " + s); };
            Func<int, int> func7 = delegate(int x) { return x + 1000; };
            Func<int> func8 = delegate { return 123 + 456; };
                       //Console.WriteLine(func1(77));
            //Console.WriteLine(func5(77 , 88));
            //Console.WriteLine(func6("Nigga"));
            Console.WriteLine(func8());

        }
        static string UpperCaseString(string inString)
        {
            return inString.ToUpper();
        }
    }
}
