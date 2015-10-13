using System;

namespace market
{
    class Meat : Food, IPerishable
    {
        public DateTime Valid { set; get; }
        public Meat(string t, string m, decimal p , DateTime v) : base(t, m, p) 
        {
            Valid = v;
        }

        public override string ToString()
        {
            return base.ToString() +
                ((Valid < DateTime.Now) ? "not valid" 
                : "use up to " + Valid.ToShortDateString());
        }
    }
}
