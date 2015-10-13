using System;
using Bankaccount;


namespace bankakkount
{
    //class EXIMBankAccount : IBankaccount
    class EXIMBankAccount : ITransferBank
    {
        private decimal _balance;

        public void PayIn(decimal amount)
        {
            _balance += amount + (amount * 2 / 100);
        }
        public bool Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            Console.WriteLine("no money no funny");
            return false;
        }

        public decimal Balance
        {
            get { return _balance; }
        }
        public bool TransferTo(IBankaccount destination,decimal amount)
        {
            bool res = false;

            if((res = Withdraw(amount)) == true)
            {
                destination.PayIn(amount);

            }
            return res;
        }

        public override string ToString()
        {
            return string.Format("EXIM Bank:balasce={0,6:C}", _balance);
        }
    }
}
