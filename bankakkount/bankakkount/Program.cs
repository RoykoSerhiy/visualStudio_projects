using System;
using Bankaccount;


namespace bankakkount
{
    class Program
    {
        static void Main()
        {
            IBankaccount acc1 = new PrivatBank();
            ITransferBank acc2 = new EXIMBankAccount();

            acc1.PayIn(200);
            acc2.PayIn(500);

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2.ToString());

            acc2.TransferTo(acc1, 100);



            //IBankaccount[] accounts = new IBankaccount[2];
            //accounts[0] = new PrivatBank();
            //accounts[1] = new EXIMBankAccount();



            //acc1.PayIn(200);
            //acc2.PayIn(100);

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2.ToString());
        }
    }
}
