using System;


namespace market
{
    abstract class Product
    {
        protected string Title;
        protected string Measure;
        protected decimal Price;
        protected string Check;

        public abstract string Category { get;  }

        public Product(string t, string m, decimal p)
        {
            Title = t;
            Measure = m;
            Price = p;
        }
        public override string ToString()
        {
            Check = "===================\n";
            Check += "Category: " + Category + "\n";
            Check += "Title:    " + Title + "\n";
            Check += "Measure:    " + Measure + "\n";
            Check += "Price:    " + "$" +Price + "\n";
            return Check;
;
        }
    }
}
