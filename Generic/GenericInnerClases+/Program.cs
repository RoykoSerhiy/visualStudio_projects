using System;
using System.Collections.Generic;


namespace GenericInnerClases
{
    class Program
    {
        class ClassA<T>
        {
            public class InnerClassA
            {

            }
        }
        class ClassB<T>
        {
            public class InnerClassB<U>
            {

            }
        }

        static void Main()
        {
            ClassA<int>.InnerClassA class1 = 
                new ClassA<int>.InnerClassA();
            Console.WriteLine(class1);
            ClassA<decimal>.InnerClassA class2 = 
                new ClassA<decimal>.InnerClassA();
            Console.WriteLine(class2);

            ClassB<int>.InnerClassB<string> class3 = 
                new ClassB<int>.InnerClassB<string>();
            Console.WriteLine(class3);
        }
    }
}
