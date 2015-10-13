using System;


namespace market
{
    class Booze : Food , IAccise
    {
        public decimal Accise { get; set; } 
        public Booze(string t, string m, decimal p , decimal ac) : base(t, m, p) 
        {
            Accise = ac;
            //Price = p + ac;
        }

        public override string ToString()
        {
            return base.ToString()+"Accsize: "+Accise+"\n"+"Price with Accise: "+ (Accise+Price);
        }
    }
}
