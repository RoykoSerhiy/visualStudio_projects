using System;
namespace market
{
    interface IPerishable
    {
        DateTime Valid { get; set; }
    }
}
