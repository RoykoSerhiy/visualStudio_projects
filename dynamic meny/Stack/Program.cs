using System;
using System.Windows;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            Stack<string> st = new Stack<string>();
            st.Push("one");
            st.Push("two");
            st.Push("three");

            foreach (string s in st)
            {
                string str = st.Pop();
                Console.WriteLine(str);
            }
        }
    }
}
