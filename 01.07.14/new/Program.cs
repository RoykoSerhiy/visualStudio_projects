using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace ReplaceDemoOne
{
    class Program
    {
        static void showMatch(string txt, string expr)
        {
            Console.WriteLine("The expression: " + expr);
            MatchCollection mc =
                Regex.Matches(txt , expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        static void Main()
        {
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match("Dot 2012 NET");

            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //}

            string str = "A Thousand Splendid Suns";
            //showMatch(str, @"\bS\S*");

            //=============================
            //(067)333-222-11
            //showMatch("(067)-333-222-11", @"\b\d\d\d-\d\d-\d\d");
            //showMatch("(067)-333-222-11", @"\b\d{3}-\d\d-\d\d");
            //showMatch("(067)-333-222-11", @"\b\d{3}(-\d{2}){2}");

            str = "make maze and manage to measure it";
            //showMatch(str ,@"\bm\S+e\b");
            str = "Alex 320, Victor 334 , Denis 278, Igor 1500";
            //showMatch(str, @"\d+");
            str = "    hello      world      ";
            string pattern = @"\s+";
            string replace = " ";
            Regex rgx = new Regex(pattern);
            string res = rgx.Replace(str , replace);

            pattern = @"^ ";
            rgx = new Regex(pattern);
            replace ="";
            res = rgx.Replace(res, replace);
            pattern = @" $";
            rgx = new Regex(pattern);
            res = rgx.Replace(res , replace);

            //Console.WriteLine("Original:\n " + str);
            //Console.WriteLine("Res:\n" + res+"|");

            str = "Today is a good day to swim";
            pattern = @"\s";

            

            rgx = new Regex(pattern);
            string[] resarr = rgx.Split(str);
            foreach(string s in resarr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
