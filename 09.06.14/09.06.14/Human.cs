using System;

namespace _09._06._14
{
    class Human
    {
        protected String _fName;
        protected String _lName;
        protected DateTime _birthday;


        public String FirstName
        {
            get { return _fName;}
            set {_fName = value;}
        }
        public string LastName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public Human() { }

        public Human(String firstName , String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Human(String firstName, String lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public virtual void Work()
        {
            //Do something
        }
    }
}
