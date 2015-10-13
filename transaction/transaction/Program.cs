using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Transactions;

namespace transaction
{
    [ServiceContract]
    public interface IBankService
    {
        [OperationContract]
        void ToDeposit(double sum);
        [OperationContract]
        double GetBalance();
    }
   
    public class BankService : IBankService
    {
        static int id = 0;
        public double Balance;

        public BankService()
        {
            ++id;
            Console.WriteLine("Cоздан счет № " + id.ToString());

        }
        [OperationBehavior(TransactionScopeRequired = true , TransactionAutoComplete = false)]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        public void ToDeposit(double sum)
        {
            Console.WriteLine("Change balance");
            this.Balance += sum;
            System.Transactions.Transaction trans =
                System.Transactions.Transaction.Current;

            double bal = GetBalance();
            Console.WriteLine("Balance: {0} Transaction ID: {1}" , bal
                , Transaction.Current.TransactionInformation.LocalIdentifier.ToString());
        }
        public double GetBalance()
        {
            Console.WriteLine("Запрос баланса");
            return this.Balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(BankService));
            sh.Open();
            Console.WriteLine("Press enter to end...");
            Console.ReadLine();
            sh.Close();
        }
    }
}
