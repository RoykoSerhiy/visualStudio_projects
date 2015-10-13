using System;
using System.IO;
using System.IO.Compression;
using System.Text;



namespace files2
{
    class Program
    {
        static void SaveCommpresedFile(string fileName , string data)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            GZipStream compStream =
                new GZipStream(fileStream, CompressionMode.Compress);
            StreamWriter sw = new StreamWriter(compStream);
            sw.Write(data);
            sw.Close();
        }
        static string LoadCompressedFile(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            GZipStream uncompStream = new GZipStream(fs, CompressionMode.Decompress);

            StreamReader sr = new StreamReader(uncompStream);
            string data = sr.ReadToEnd();
            sr.Close();
            return data;
        }
        static void Main()
        {
            try
            {
                string fileName = "file1.zip";
                Console.WriteLine("Eneter String:");
                string sourseStream = Console.ReadLine();

                StringBuilder sb = new StringBuilder(sourseStream.Length * 100);
                for (int i = 0; i < 100; i++)
                {
                    sb.Append(sourseStream);
                }
                sourseStream = sb.ToString();

                Console.WriteLine("Source Data is {0} bytes long", sourseStream.Length);
                SaveCommpresedFile(fileName, sourseStream);
                Console.WriteLine("Data Save to{0}" , fileName);
                string recoveryString = LoadCompressedFile(fileName);
                recoveryString = recoveryString.Substring(0, recoveryString.Length / 100);
                Console.WriteLine("Recovered Data: {0}" ,recoveryString );
            }
            catch(IOException e)
            {
            }

        }
    }
}
