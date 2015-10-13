using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum PersonMaritalStatus
    {
        Merried,
        Single
    }
    [Serializable]
    public class Person
    {
        public string fName;
        public string lName;
        public int Age;
        PersonMaritalStatus status;
        public Person(string fname, string lname, int age)
        {
            fName = fname;
            lName = lname;
            Age = age;
            status = PersonMaritalStatus.Single;
        }
        public void Print()
        {
            Console.WriteLine("Person:\nName: " + fName + "\nLast Name :" + lName 
                + "\nAge :" + Age);
        }

    }
    public class Employer : Person
    {
        string Position;
        decimal Salary;
        public Employer(string fName , string lName , int Age , string position 
            , decimal salary) : base(fName , lName , Age)
        {
            this.Position = position;
            this.Salary = salary;
        }
             


    }
        
}
