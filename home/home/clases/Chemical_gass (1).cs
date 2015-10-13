namespace market
{
    class Chemical_gass : Chemical, IFlameble
    {
        public string Caution
        {
            get { return "Caution! It's Flameble"; }
        }

        public Chemical_gass(string title, string measure, decimal price) :
            base(title, measure, price) { }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                Caution;

        }
    }
}
