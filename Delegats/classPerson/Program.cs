using System;


namespace classPerson
{
    struct Person
    {
        public string _firstName;
        public string _lastName;
        public DateTime _birthDay;

        public Person(string f, string l, DateTime b)
        {
            _firstName = f;
            _lastName = l;
            _birthDay = b;
        }

        public override string ToString()
        {
            return _lastName + " " + _firstName + ": " + _birthDay;
        }

        public static string GetType() { return "Human"; }
    }

    class MainEntryPoing
    {
        delegate string GetAsStrng();

        static void Main()
        {
            DateTime birthDay = new DateTime(1980, 6, 16);
            Person person = new Person("petya" , "lomov" , birthDay);
            GetAsStrng getStringMethod = 
                new GetAsStrng(birthDay.ToLongDateString);
            Console.WriteLine(getStringMethod());

            getStringMethod = Person.GetType;
            Console.WriteLine(getStringMethod());

            getStringMethod = person.ToString;
            Console.WriteLine(getStringMethod());


        }
    }
}
