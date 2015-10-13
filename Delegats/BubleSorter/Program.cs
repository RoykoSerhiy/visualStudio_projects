using System;
public delegate bool Comparer(object lhs , object rhs);

namespace BubleSorter
{
    static class BubbleSortter
    {
        static public void Sort(object[] arr, Comparer comparer)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (comparer(arr[j], arr[i]))
                    {
                        object tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                    
                  }
                }
            }
        }

    class Employer
    {
        string _name;
        decimal _salary;

        public Employer(string n, decimal s)
        {
            _name = n;
            _salary = s;
        }

        public override string ToString()
        {
            return string.Format(_name+": {0}" , _salary);
        }
        public static bool RhsIsGreater(object lhs, object rhs)
        {
            Employer empLhs = (Employer)lhs;
            Employer empRhs = (Employer)rhs;

            return (empRhs._salary > empLhs._salary) ? true : false;
        }
    }

    class Program
    {
        static void Main()
        {
            Employer[] employees = 
            {
                new Employer("Pupkin V." , 2000),
                new Employer("Bubkin P." , 1500),
                new Employer("Zubkin M." , 350)

            };
            Comparer employeeComp = new Comparer(Employer.RhsIsGreater);
            BubbleSortter.Sort(employees, employeeComp);

            foreach(Employer em in employees)
            {
                Console.WriteLine(em.ToString());
            }
        }
    }
}
