using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace SearshFiles
{
    class Program
    {
        static Dictionary<string, int> found = new Dictionary<string, int>();

        static string curDir = "D:\\temps";
        static void Main()
        {
            SearchDir(curDir);
            foreach (var current in found.Keys)
            {
                Console.WriteLine(found[current]+" "+current);
            }
            CleanDir(curDir);


        }

        static void SearchDir(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            string[] directories = Directory.GetDirectories(folder);

            var extention =
                (from file in files
                 select Path.GetExtension(file)).Distinct();

            foreach (var ext in extention)
            {
                var extentionCount = (from file in files
                                      where Path.GetExtension(file) == ext
                                      select file).Count();

                if (found.ContainsKey(ext))
                {
                    found[ext] += extentionCount;
                }
                else
                {
                    found.Add(ext , extentionCount);
                }
                foreach (var subdirectory in directories)
                {
                    SearchDir(subdirectory);
                }


            }
            
        }

        static void CleanDir(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            string[] directories = Directory.GetDirectories(folder);

            var tmpFiles =
                from file in files
                where Path.GetExtension(file) == ".tmp"
                select file;

            foreach (var tmp in tmpFiles)
            {
                File.Delete(tmp);
                Console.WriteLine(tmp + "Was Deleted");
            }
            foreach (var dir in directories)
            {
                CleanDir(dir);
            }
        }
    }
}
