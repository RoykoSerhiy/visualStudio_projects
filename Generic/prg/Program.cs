using System;
using System.Collections.Generic;


namespace prg
{
    interface ICalc<T>
    {
        T Sum(T a);
    }

    class Program
    {
        class calcInt : ICalc<calcInt>
        {
            int _a = 0;

            public calcInt(int a)
            {
                _a = a;
            }
            public calcInt Sum(calcInt b)
            {
                return new calcInt(_a + b._a);
            }
            public override string ToString()
            {
                return _a.ToString();
            }

        }
        class MyArray<T> where T : ICalc<T>
        {
            List<T> _list = new List<T>();
            public void Add(T t)
            {
                _list.Add(t);
            }
            public T Sum()
            {
                if (_list.Count == 0)
                {
                    return default(T);
                }
                T res = _list[0];
                for (int i = 1; i < _list.Count; ++i)
                {
                    res = res.Sum(_list[i]);
                }
                return res;
            }
        }

        static void Main()
        {
            MyArray<calcInt> arr = new MyArray<calcInt>();
            arr.Add(new calcInt(22));
            arr.Add(new calcInt(33));
            
            Console.WriteLine(arr.Sum());
        }
    }
}
