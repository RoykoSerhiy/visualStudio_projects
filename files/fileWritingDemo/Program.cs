using System;
using System.IO;
using System.Text;

namespace fileWritingDemo
{
    class Program
    {
        static void Main()
        {
            byte[] byData = new byte[200];
            char[] charData = new char[200];
            try
            {
                FileStream aFile = new FileStream("Temp.txt", FileMode.Create);
                charData = "Hello World".ToCharArray();
                byData = new byte[charData.Length];

                Encoder e = Encoding.UTF8.GetEncoder();
                e.GetBytes(charData, 0, charData.Length, byData, 0, true);
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Write(byData, 0, byData.Length);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
