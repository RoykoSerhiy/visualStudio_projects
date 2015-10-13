using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace isCompleted
{
    class Program
    {
        private static Byte[] data = new Byte[100];
        static void Main(string[] args)
        {
           // FileStream fs = new FileStream(@"../../Program.cs" , FileMode.Open , FileAccess.Read,
           //     FileShare.Read , 1024 , FileOptions.Asynchronous
           //     );
           //
           // byte[] data = new byte[100];
           // 
           // IAsyncResult ar = fs.BeginRead(data, 0, data.Length, null, null);
           // while(!ar.IsCompleted)
           // {
           //     Console.WriteLine("Operation is not completed , wait...");
           //     Thread.Sleep(10);
           // }
           //
           // int bytesRead = fs.EndRead(ar);
           // fs.Close();
           // Console.WriteLine("Bytes :" + bytesRead);
           // Console.WriteLine(Encoding.UTF8.GetString(data));

            //FileStream fs = new FileStream(@"../../Program.cs", FileMode.Open, FileAccess.Read,
            //   FileShare.Read, 1024, FileOptions.Asynchronous
            //   );
            //
            //byte[] data = new byte[100];
            //
            //IAsyncResult ar = fs.BeginRead(data, 0, data.Length, null, null);
            //while (!ar.AsyncWaitHandle.WaitOne(10 , false))
            //{
            //    Console.WriteLine("Operation is not completed , wait...");
            //   
            //}
            //
            //int bytesRead = fs.EndRead(ar);
            //fs.Close();
            //Console.WriteLine("Bytes :" + bytesRead);
            //Console.WriteLine(Encoding.UTF8.GetString(data));

            //Console.WriteLine("Main stream ID = {0}" , Thread.CurrentThread.ManagedThreadId);
            //FileStream fs = new FileStream(@"../../Program.cs", FileMode.Open, FileAccess.Read,
            //   FileShare.Read, 1024, FileOptions.Asynchronous
            //   );
            //fs.BeginRead(data , 0 , data.Length , ReadIsComplete , fs);
            //Console.ReadLine();

        }
       // private static void ReadIsComplete(IAsyncResult ar)
       // {
       //     Console.WriteLine("Read in stream {0} complete" , Thread.CurrentThread.ManagedThreadId);
       //
       //     FileStream fs = (FileStream)ar.AsyncState;
       //
       //     int bytesRead = fs.EndRead(ar);
       //     fs.Close();
       //     Console.WriteLine("Bytes = {0}" , bytesRead );
       //     Console.WriteLine(Encoding.UTF8.GetString(data).Remove(0, 1));
       // }
    }
}
