


namespace market
{
    class Acid : Chemical, IBrakeble
    {
        public string Caution
        {
            get { return "Caution! It`s brakeble"; }
        }


        public Acid(string t, string m, decimal p) 
            : base(t, m, p) { }
        public override string ToString()
        {
            return base.ToString()+"\n" + Caution;
        }
    }
}
