/////////3.5///////////


using System;


namespace Ukraine
{
    class Kiev
    {
        public int population
        {
             get { return 2700000; }
        }
    }
}
namespace Poland
{
    class Varshava
    {
        public int population
        {
            get { return 2500000; }
        }
    }
}
namespace Franse
{
    class Paris
    {
        public int population
        {
            get { return 2900000; }
        }
    }
}
    class Program
    {
        static void Main()
        {
            Franse.Paris parise = new Franse.Paris();
            Ukraine.Kiev kiev = new Ukraine.Kiev();
            Poland.Varshava varshava = new Poland.Varshava();

            if (parise.population > kiev.population && parise.population > varshava.population)
            {
                Console.WriteLine("Parise population the most");
            }
            else
                if (kiev.population > parise.population && kiev.population > varshava.population)
                {
                    Console.WriteLine("Kiev population the most");
                }
                else
                {
                     Console.WriteLine("Varshava population the most");
                }
        }
    }