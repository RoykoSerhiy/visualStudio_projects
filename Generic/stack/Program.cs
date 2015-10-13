using System;
using System.Collections;
using System.Collections.Generic;

public delegate void ChangedEventHandler(object sender , EventArgs e);


namespace stack
{
    class ListWithCahngedEvent : ArrayList
    {
        public event ChangedEventHandler Changed;

        protected virtual void onChanged(EventArgs e)
        {
            if (Changed != null)
            {
                //Changed(this , e);
            }
        }

        public override int Add(object value)
        {
           int i = base.Add(value);
           onChanged(EventArgs.Empty);

           return i;
        }

        public override void Clear()
        {
            base.Clear();
            onChanged(EventArgs.Empty);
        }
        public override object this[int index]
        {
         
          set
            {
                base[index] = value;
                onChanged(EventArgs.Empty);
            }
        }
    }

    class EventListener
    {
        ListWithCahngedEvent _list;
        public EventListener(ListWithCahngedEvent list)
        {
            _list = list;
            _list.Changed += new ChangedEventHandler(ListChanged);
        }

        void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Something happend");
        }
        public void Detach()
        {
            _list.Changed -= new ChangedEventHandler(ListChanged);
            _list = null;
        }
    }

    class Program
    {
        static void Main()
        {
            ListWithCahngedEvent list = new ListWithCahngedEvent();

            EventListener listener = new EventListener(list);
            list.Add("obj1");
            list.Add("obj2");
        }
    }
}
