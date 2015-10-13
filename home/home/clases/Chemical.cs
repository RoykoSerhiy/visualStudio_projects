namespace market
{
    abstract class Chemical : Product
    {
        public Chemical(string t, string m, decimal p):base(t, m, p){}

        public override string Category
        {
            get { return "Chemical"; }
        }
    }
}
