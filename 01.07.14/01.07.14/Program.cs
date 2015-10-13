using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _01._07._14
{
    class Program
    {
        static void Main()
        {
            string str = "OneTwoThree";
            int i1 = str.IndexOf("One");
            if (i1 != -1)
            {
                int i2 = str.LastIndexOf("Three");
                if (i2 != -1)
                {
                    int start = i1 + "One".Length;
                    int len = i2 - start;
                    Console.WriteLine(str.Substring(start, len));
                }
               
            }
            Regex r1 = new Regex(@"One([A-Za-z0-9]+)Three");
            Match match = r1.Match(str);
            if (match.Success)
            {
                string v = match.Groups[1].Value;
                Console.WriteLine(v);
            }
        }
    }
}
