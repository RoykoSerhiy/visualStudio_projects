using System;


namespace AnonimMethods
{
    class Program
    {
        delegate string delegateTest(string val);

        static void Main()
        {
            string mid = ", middle part of string ,  ";

            delegateTest test = delegate(string param)
            {
                param += mid;
                param += "and finally - end.";

                    return param;
            };
            Console.WriteLine(test("Start of out string"));
        }
    }
}
