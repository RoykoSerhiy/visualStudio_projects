using System;


namespace clases
{
    //class PhoneCustomer
    //{
    //    public const string DayOfSendingBill = "Monday";
    //    public int CustomerId;
    //    public string FeirstName;
    //    public string LastName;
    //}
    //struct PhoneCustomerStruct
    //{
    //    public const string DayOfSendingBill = "Monday";
    //    public int CustomerId;
    //    public string FeirstName;
    //    public string LastName;
    //}

    class Program
    {

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                    Person p = (Person)obj;
                    if (this.Name == p.Name && this.Age == p.Age)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }

            public override int GetHashCode()
            {
                return 1;
            }

            public override string ToString()
            {
                return "Person:"+ Name +" "+ Age;
            }
            public static bool operator == (Person p1 , Person p2)
            {
                if (p1.Name == p2.Name && p1.Age == p2.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool operator !=(Person p1, Person p2)
            {
                if (p1.Name != p2.Name && p1.Age == p2.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            //PhoneCustomer myCustomer = new PhoneCustomer();
            //PhoneCustomerStruct myCustomer2 = new PhoneCustomerStruct();

            ////if (myCustomer2 is ValueType)
            ////{
            ////    Console.WriteLine("ValueType:");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("not ValueType:");
            ////}
            //Console.WriteLine((myCustomer2 is ValueType) ? "ValueType":"NotValType");


            Person person1 = new Person { Name = "Petya" , Age = 11};
            Person person2 = new Person { Name = "Petya", Age = 22 };
            Person person3 = new Person { Name = "Petya", Age = 11 };
            Person person4 = person1;
            Person person5 = null;
            Person person6 = null;


            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Equals(person3));
            Console.WriteLine(person4.Equals(person1));

            Console.WriteLine("hash:"+person1.GetHashCode());
            Console.WriteLine(person2.ToString());

            Console.WriteLine(person1==person3);
            Console.WriteLine(person1 != person2);


            Console.WriteLine(person5 != person6);

        }
    }
}
