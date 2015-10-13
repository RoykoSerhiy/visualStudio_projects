using System;

namespace market
{
    class Potato : Food
    {

        public Potato(string title, string meashue, decimal price)
            : base(title, meashue, price)
        { }

        public override string ToString()
        {
            return base.ToString() + "\nIt`s good =)";
        }
    }
}
