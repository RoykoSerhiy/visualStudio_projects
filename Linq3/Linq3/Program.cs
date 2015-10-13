using System;
using System.Collections;
using System.IO;


namespace Linq3
{
    class Program
    {
        static void Main()
        {
            string path_;
            Console.WriteLine("enter the path to the folder");
            path_ = Console.ReadLine();

            DirectoryInfo dirInfo = new DirectoryInfo(path_);

           
            string[] videoTypes = { "*.avi", "*.mp4", "*.move" ,"*.3gp"};
            ArrayList videoList = new ArrayList();
            foreach (string ext in videoTypes)
            {
                FileInfo[] fileInfo = dirInfo.GetFiles(ext);
                videoList.AddRange(fileInfo);

            }
            for (int i = 0; i < videoList.Count; ++i)
            {
                FileInfo file = (FileInfo)videoList[i];
                Console.WriteLine("- "+file.Name);
            }


        }
    }
}
