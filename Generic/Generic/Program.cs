using System;
using System.Collections;

namespace Generic
{
    class Program
    {
        static void Main()
        {
            ArrayList alist = new ArrayList();
            alist.Add(777);

            try
            {
                short a = (short)alist[0];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
