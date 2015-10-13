using System;

namespace Delegats
{
    class Program
    {

        private delegate string GetAsString();

        static void Main()
        {
            int x = 40;

            GetAsString firstStringMethod = new GetAsString(x.ToString);

            Console.WriteLine("our string is: " + firstStringMethod());
        }
    }
}
