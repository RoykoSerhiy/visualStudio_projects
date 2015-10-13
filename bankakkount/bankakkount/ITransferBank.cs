using Bankaccount;
namespace bankakkount
{
    interface ITransferBank : IBankaccount
    {
        bool TransferTo(IBankaccount destination, decimal amount);
    }
}
