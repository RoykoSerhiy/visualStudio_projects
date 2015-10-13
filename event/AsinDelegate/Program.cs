using System;
using System.Threading;
delegate string AsynDelegate();
namespace AsinDelegate
{
    
    
    


    


   


    class Program
    {
         public static string LargeTask()
        {
            Thread.Sleep(3000);
            return "success";
        }

         public static void CallBackLargeTask(IAsyncResult asyncResult)
         {
             AsynDelegate doLargeTask = (AsynDelegate)asyncResult.AsyncState;

             string message = doLargeTask.EndInvoke(asyncResult);
             Console.WriteLine(message);
         }

        static void Main()
        {
            AsynDelegate delegateObj = LargeTask;

            delegateObj.BeginInvoke(new AsyncCallback(CallBackLargeTask), delegateObj);

            Console.WriteLine("New Task Started!!!!!!!!");

            Console.WriteLine("press any key...");
            Console.ReadKey();
        }
    }
}
