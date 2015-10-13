using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


namespace _02._07._14
{
    class Program
    {
        static void Main()
        {
            //string str = "qwerty";
            //string source = "The inserted text is here -><- !!!";
            //Console.WriteLine(source.Insert(source.LastIndexOf('<'), str)); 
           // string s1 = "--TEST--";
           // string s2 = ",-TEST--";
           // string s3 = ".,-TEST--";
           // string s4 = ".,~-TEST--";
           // Console.WriteLine(method(s1));
           // Console.WriteLine(method(s2));
           // Console.WriteLine(method(s3));
           // Console.WriteLine(method(s4));
            //int i = 5,x = 10 , y = 15;
            //Func(out i, out x, out y);
            //Console.WriteLine("i = "+i+" x= "+x+" y = "+y+";");

            //string fileName = @"C:\mydir.old\myfile.ext";
            //string path = @"C:\mydir.old\";
            //string extension;
            //
            //extension = Path.GetExtension(fileName);
            //Console.WriteLine("GetExtension('{0}') returns '{1}'",
            //    fileName, extension);
            //
            //extension = Path.GetExtension(path);
            //Console.WriteLine("GetExtension('{0}') returns '{1}'",
            //    path, extension);
            //
            string fileName = @"C:\mydir\myfile.ext";
            string path = @"C:\mydir\";
            string result;

            result = Path.GetFileName(fileName);
            Console.WriteLine("GetFileName('{0}') returns '{1}'",
                fileName, result);

            result = Path.GetFileName(path);
            Console.WriteLine("GetFileName('{0}') returns '{1}'",
                path, result);

        }
        //static string method(string str)
        //{
        //    char[] p = {'-',',','.','~'};
        //    return str.TrimStart(p);
        //}
        //static void Func(out int i,out  int x,out int y)
        //{
        //    i = 10;
        //    x = (i * i + 10);
        //    y = (x * x + 100);
        //    //return i;
        //}
    }
}
