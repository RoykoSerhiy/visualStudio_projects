using System;
public delegate void EventHandler();

namespace _event
{
    class Program
    {
        static void Cat()
        {
            Console.WriteLine("Cat");
        }
        static void Dog()
        {
            Console.WriteLine("Dog");

        }
        static void Mouse()
        {
            Console.WriteLine("Mouse");
        }
        public static event EventHandler _show;
        static void Main()
        {
            _show += new EventHandler(Cat);
            _show += new EventHandler(Dog);
            _show += new EventHandler(Mouse);
            _show.Invoke();
        }
    }
}
