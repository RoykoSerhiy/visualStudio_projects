using System;
using Bankaccount;


namespace bankakkount
{
    class PrivatBank : IBankaccount
    {
        private decimal _balance;

        public void PayIn(decimal amount)
        {
            _balance += amount;
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
        public override string ToString()
        {
            return string.Format("Privat Bank:balasce={0,6:C}",_balance);
        }
    }
}
