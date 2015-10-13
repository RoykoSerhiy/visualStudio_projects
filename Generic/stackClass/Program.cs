using System;
using System.Collections;
using System.Collections.Generic;

public delegate void EventHandler();
//public delegate void ChangedEventHandler(object sender, EventArgs e);

namespace stackClass
{
    //class ListEvents : ArrayList
    //{
    //    public event ChangedEventHandler Changed;

    //    protected virtual void onChanged(EventArgs e)
    //    {
    //        if (Changed != null)
    //        {
    //            Changed(this, e);
    //        }
    //    }
    //}
        
    interface IStack<T>
    {
        void Push(T item);
        T Pop();
        int Size { get; }
    }
       
    class Stack<T> : IStack<T> where T : IComparable<T>
    {
        private class ItemHolder<E>
        {
            public E Item { get; set; }
            public ItemHolder<E> Next { get; set; }
        }
        public static event EventHandler _show;
        private ItemHolder<T> head = null;
        private int size = 0;
        
        static void sPop()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pop works:\n");
        }
        static void sPush()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Push works:\n");
        }
        static void EmptyStack()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Stack Is Empty:\n");
        }
        public void Push(T item)
        {
            ItemHolder<T> ih = new ItemHolder<T>
            {
                Item = item,
                Next = head
            };

            head = ih;
            size += 1;
            _show = new EventHandler(sPush);
            _show.Invoke();
        }

        public T Pop()
        {
            if(size == 0)
            {
                _show = new EventHandler(EmptyStack);
                _show.Invoke();
                return default(T);
            }
          
                size -= 1;
                ItemHolder<T> ih = head;
                head = head.Next;
                _show = new EventHandler(sPop);
                _show.Invoke();
                
            
            return ih.Item;
            
        }
        public int Size
        {
            get { return size; }
        }
    }
    class Program
    {
        static void Main()
        {

            IStack<decimal> stack = new Stack<decimal>();

                stack.Push((decimal)1.0);
                stack.Push((decimal)2.0);
                stack.Push((decimal)3.0);

            while (stack.Size != 0)
            {
                //Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pop ["+ stack.Size +"] = "+stack.Pop());
            }
            stack.Pop();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
