using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] files = {"../../Program.cs",
            //                  "../../Async.csproj",
            //                  "../../Properties/AssemblyInfo.cs"};
            //AsyncReader[] asrArr = new AsyncReader[3];
            //for (int i = 0; i < asrArr.Length; ++i)
            //{
            //    asrArr[i] = new AsyncReader(new FileStream(files[i] , FileMode.Open , FileAccess.Read ,FileShare.Read) , 100);
            //}
            //foreach (AsyncReader asr in asrArr)
            //{
            //    Console.WriteLine(asr.EndRead());
            //}


            //FileStream fs = new FileStream(@"../../Program.cs" , FileMode.Open , FileAccess.Read,
            //    FileShare.Read , 1024 , FileOptions.Asynchronous
            //    );

            //byte[] data = new byte[900];
            //
            //IAsyncResult ar = fs.BeginRead(data, 0, data.Length, null, null);
            //int bytesRead = fs.EndRead(ar);
            //fs.Close();
            //Console.WriteLine("Bytes :" + bytesRead);
            //Console.WriteLine(Encoding.UTF8.GetString(data));

        }
        //class AsyncReader
        //{
        //    FileStream stream;
        //    byte[] data;
        //    IAsyncResult asRes;
        //
        //    public AsyncReader(FileStream s, int size)
        //    {
        //        stream = s;
        //        data = new byte[size];
        //        asRes = s.BeginRead(data, 0, size, null, null);
        //    }
        //    public string EndRead()
        //    {
        //        int countByte = stream.EndRead(asRes);
        //        stream.Close();
        //        Array.Resize(ref data, countByte);
        //        return string.Format("File: {0}\n{1}\n\n", stream.Name, Encoding.UTF8.GetString(data));
        //
        //    }
        //}
    }
}
