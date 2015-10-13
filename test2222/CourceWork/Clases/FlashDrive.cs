using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourceWork.Clases
{
    public class FlashDrive
    {
        public string path { get; set; }
        public string SerialNum { get; set; }
        public string Size { get; set; }
        public bool isWhite { get; set; }


        public void CheckList()
        {
            string[] lines = File.ReadAllLines("WhiteList.txt");
            foreach (string l in lines)
            {
                if (SerialNum == l)
                {
                    isWhite = true;
                    break;
                }
                else
                {
                    isWhite = false;
                }
            }
        }
        public void AddToWhiteList(string serial)
        {
               StringBuilder sb = new StringBuilder();
               StreamWriter sw = new StreamWriter("WhiteList.txt", true);
               sb.AppendLine(serial);
               sw.WriteLine(serial);
               sw.Close();
           
        }
        public void DeleteFromWhiteList(string serial)
        {
            string[] lines = File.ReadAllLines("WhiteList.txt");
            List<string> Lines = new List<string>();

            int count = 0;
            foreach (string s in lines)
            {
                Lines.Add(s);
            }
            foreach (string l in Lines)
            {
                if (l == serial)
                {
                    Lines.RemoveAt(count);
                    File.WriteAllLines("WhiteList.txt", Lines);
                   
                    break;
                }
                ++count;
            }
        }
        public void CopyFiles(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    CopyFiles(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        public void CopyFilesbyExtention(string sourceDirName, string destDirName, string extention ,bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (extention == file.Extension)
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, false);
                }
            }
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    CopyFilesbyExtention(subdir.FullName, temppath, extention,copySubDirs);
                }
            }
        }
    }
}
