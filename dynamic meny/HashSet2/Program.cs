using System;
using System.Collections.Generic;
using System.Linq;


namespace HashSet2
{
    class Program
    {
        static void Main()
        {
            var companyTeams =
                new HashSet<string>(){ "Ferrari", "McLaren", "Mersedes" };
            var traditionalTeams =
                new HashSet<string>() { "Ferrari", "McLaren" };
            var privateTeams =
                new HashSet<string>() { "Red Bull", "Lotus", "Toro Rosso", "Force India", "Sauber" };
            if (traditionalTeams.IsSubsetOf(companyTeams))
            {
                Console.WriteLine("tradTeam is subset of company Teams");
            }

        }
    }
}
