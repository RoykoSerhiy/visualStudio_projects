using System;


namespace class_work
{
    class TryCatchEx
    {
       static void A()
        {
            try
            {
                int val = 1 / int.Parse("0");
            }
            catch
            {
                Console.WriteLine("Method A() is done");
            }
            finally
            {
                Console.WriteLine("ha-ha");
            }
        }
       static void B()
       {
           int val = 1 / int.Parse("0");
           Console.WriteLine("method B() is done");
       }
       static void Main()
       {


           A();
           B();
       }
    }
    
}
