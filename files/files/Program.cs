using System;
using System.IO;


namespace SimpleFilesDemo
{
    class Program
    {
        static void Main()
        {
            string fileName = "c:\\file1.txt";

            if (File.Exists(fileName))
            {
                Console.WriteLine("OK");
                using (FileStream fileStream = File.OpenRead(fileName))
                {
                    long length = fileStream.Length;
                    Console.WriteLine(length);
                    Console.WriteLine("Created:" + File.GetCreationTime(fileName));
                    Console.WriteLine("Last acsees:"+ File.GetLastAccessTime(fileName));
                }
            }
            else
            {
                Console.WriteLine("Not OK =(");
            }
        }
    }
}