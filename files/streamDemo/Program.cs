using System;
using System.IO;
using System.Text;


namespace streamDemo
{
    class Program
    {
        static void Main()
        {
            byte[] byData = new byte[200];
            char[] charData = new char[200];
            try
            {
                FileStream aFile = new FileStream("../../Progtam.cs", FileMode.Open);
                aFile.Seek(110, SeekOrigin.Begin);
                aFile.Read(byData, 0, 200);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(by)
        }
    }
}
