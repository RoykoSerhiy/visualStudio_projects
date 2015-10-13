using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;


namespace files
{
   
   //class FS
   //{
   //    public string name;
   //
   //    public FS(string _name)
   //    {
   //        name = _name;
   //    }
   //    public void FileSearch(string name int size , 
   //}
    class Program
    {
       // static Dictionary<string, int> found =
       //     new Dictionary<string, int>();
       
        //static string currentDirectory = "d:\\CS";
        static void Menu()
        {
            try
            {
                int menu;
                do
                {
                    Console.WriteLine("Chose:");
                    Console.WriteLine("0.Exit:");
                    Console.WriteLine("1.File Search:");
                    Console.WriteLine("2.Directory Search:");
                    Console.WriteLine("3.Searc By Content:");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("=======File=Search========");
                                    Console.WriteLine("Enter filename:");
                                    string filename = Console.ReadLine();
                                    Console.WriteLine("Enter path to search:");
                                    string path = Console.ReadLine();
                                    FileSearch(filename, @path);
                                }
                                catch (Exeption ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            } break;
                        case 2:
                            {
                                try
                                {

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("=======Directory=Search========");
                                    Console.WriteLine("Enter Directoy Name:");
                                    string dirname = Console.ReadLine();
                                    Console.WriteLine("Enter path to search:");
                                    string path = Console.ReadLine();
                                    DirSearch(dirname, @path);
                                }
                                catch (Exeption ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            } break;
                        case 3:
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("=======Search=By=Content========");
                                    Console.WriteLine("Enter Content:");
                                    string content = Console.ReadLine();
                                    Console.WriteLine("Enter path to search:");
                                    string path = Console.ReadLine();
                                    SearchByContent(content ,@path);
                                }
                                catch (Exeption ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }break;
                        case 4:
                            {
                                txtred(@"D:/");
                            }break;
                    }
                } while (menu != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           }
        static void Main()
        {
          
            Menu();
            
            //FileSearch("vorbisFile.dll", @"D:/");
        }
        static void FileSearch(string name , string path)
        {
            string[]files= Directory.GetFiles(path);
            ArrayList arr = new ArrayList();
            //string[] dirs = Directory.GetDirectories(path);
            int i  = 0;
            foreach(string f in files)
            {
                 arr.Add(Path.GetFileName(f));
                
            }
            try
            {
                Console.WriteLine("1.Search by format");
                Console.WriteLine("2.Search by fullname");
                Console.WriteLine("Enter chose:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exeption ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            
            foreach(string obj in arr)
            {
                if (i == 1)
                {
                    if (obj.Replace(path, " ").IndexOf(name) >= 0)
                    {

                        Console.WriteLine("File is found: {0} in: {1}", obj, path);

                    }
                }
                else
                {

                    if ((string)obj == name)
                    {
                        
                        Console.WriteLine("File is found: {0} in: {1}", obj , path);
                        
                    }
                    
                }
            }
            
        }
        static void DirSearch(string name, string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            
            //string res = path + "/" + name;
            foreach (string dir in dirs)
            {
                if (dir == String.Concat(path ,name))
                {
                    Console.WriteLine("Dir {0} found in {1}", dir, path);
                }
            }
           
        }
        static void SearchByContent(string cont, string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                ArrayList arrlist = new ArrayList();


                foreach (string obj in files)
                {

                    if (obj.Replace(path, " ").IndexOf(".txt") >= 0)
                    {
                        arrlist.Add(obj);
                    }

                }
                foreach (object obj in arrlist)
                {
                    StreamReader sr = File.OpenText((string)obj);
                    string content = "";
                    while ((content = sr.ReadLine()) != null)
                    {
                        if (content.IndexOf(cont) >= 0)
                        {
                            Console.WriteLine("Finding in {0} name:{1}" , path , obj);
                        }
                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        static void txtred(string path)
        {
            string[] files = Directory.GetFiles(path);
            Dictionary<int , string>kollection = new Dictionary<int , string>();
            int count = 1;

            foreach (string obj in files)
            {

                if (obj.Replace(path, " ").IndexOf(".txt") >= 0)
                {

                    kollection.Add(count, obj);
                    count++;
                }

            }
            foreach (object s in kollection)
            {
                Console.WriteLine(s);
            }
        }
    }
}
