using System;


namespace Factory
{
    abstract class Position
    {
        public abstract string Title { get; }

    }

    class Manager : Position
    {
        public override string Title
        {
            get { return "Manager"; }
        }
    }

    class Driver : Position
    {
        public override string Title
        {
            get { return "Driver"; }
        }
    }

    class Programmer : Position
    {
        public override string Title
        {
            get { return "Programmer"; }
        }
    }

    static class Factory
    {
        public static Position Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new Manager();
                case 1:
                case 2:
                    return new Driver();
                case 3:
                default: 
                    return new Programmer();

                    
            }
        }
    }


    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; ++i)
            {
                var position = Factory.Get(i);
                Console.WriteLine("Where id = {0} , position = {1}" ,  i , position.Title);
            }
        }
    }
}
