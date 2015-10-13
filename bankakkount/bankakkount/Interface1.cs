namespace Bankaccount
{
    interface IBankaccount
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);

        decimal Balance
        {
            get;
        }
    }
}
