using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            BankServiceClient proxy = new BankServiceClient();
            Console.WriteLine("Enter sum of deposit:");
            double sum = Convert.ToDouble(Console.ReadLine());
            

            while (sum > 0)
            {
                proxy.ToDeposit(sum);
                
                
               
                sum = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Press Enter to end...\n\n");
            Console.ReadLine();
        }
    }
}
