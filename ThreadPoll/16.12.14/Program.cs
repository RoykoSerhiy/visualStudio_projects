using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16._12._14
{
    class Program
    {
        //private static Byte[] staticData = new Byte[100]; 
        
        static void Main(string[] args)
        {
            //Byte[] data = new Byte[100];
            //Console.WriteLine("Main thread ID = {0}" , Thread.CurrentThread.ManagedThreadId);
            //FileStream fs = new FileStream(@"../../Program.cs" , FileMode.Open  , FileAccess.Read , FileShare.Read , 1024 , FileOptions.Asynchronous);
            //
            //fs.BeginRead(data, 0, data.Length,
            //    delegate(IAsyncResult ar)
            //    {
            //        Console.WriteLine("Read in thread {0} complete" , Thread.CurrentThread.ManagedThreadId);
            //        int bytesRead = fs.EndRead(ar);
            //        fs.Close();
            //        Console.WriteLine("Quantity read bytes = {0}" , bytesRead);
            //        Console.WriteLine(Encoding.UTF8.GetString(data));
            //        Console.ReadLine();
            //    }
            //    ,null);
            //Console.ReadLine();

            try
            {
                string[] files = {"../../Program.cs",
                              "../../16.12.14.csproj",
                              "../../Properties/AssemblyInfo.cs"};

                for (int i = 0; i < files.Length; ++i)
                {
                    new AsyncCallBackReader(
                        new FileStream(files[i],
                            FileMode.Open, FileAccess.Read, FileShare.Read, 1024
                            , FileOptions.Asynchronous), 100,
                            delegate(Byte[] data)
                            {
                                Console.WriteLine("quantity read bytes = {0}", data.Length);
                                Console.WriteLine(Encoding.UTF8.GetString(data) + "\n\n");
                            }
                            );
                    Console.ReadLine();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public delegate void AsyncBytesReadDel(Byte[] streamData);
        class AsyncCallBackReader
        {
            FileStream stream;
            byte[] data;
            IAsyncResult asRes;
            AsyncBytesReadDel callbackMethod;

            public AsyncCallBackReader(FileStream s, int size, AsyncBytesReadDel meth)
            {

                stream = s;
                data = new byte[size];
                callbackMethod = meth;
                asRes = s.BeginRead(data, 0, size, ReadIsComplete, null);
            }

            public void ReadIsComplete(IAsyncResult ar)
            {
                try
                {
                    int countBytes = stream.EndRead(asRes);
                    stream.Close();
                    Array.Resize(ref data, countBytes);
                    callbackMethod(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}
