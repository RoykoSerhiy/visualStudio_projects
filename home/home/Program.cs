using System;


namespace market
{
    


    class Program
    {
        static void Main()
        {
            Product acid = new Acid("Acid HCl", "bottle", (decimal)10.99);
            Console.WriteLine(acid.ToString());
            Product meat = new Meat("Pork", "1kg.", (decimal)59.99,
                new DateTime(2014, 6, 18));
            Console.WriteLine(meat);
            Product booze = new Booze("Beer", "l.", (decimal)1.99,
                (decimal)0.55);
            Console.WriteLine(booze);
            Product pot = new Potato("Good", "1kg.", (decimal)5.99);
            Console.WriteLine(pot);
            Product gas = new Chemical_gass("Gas", "bottle", (decimal)2.99);
            Console.WriteLine(gas);
            
        }
    }
}
