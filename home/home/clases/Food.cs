

namespace market
{
    abstract class Food : Product
    {
        public Food(string t, string m, decimal p) : base(t, m, p) { }

        public override string Category
        {
            get { return "Food"; }
        }
    }
}
