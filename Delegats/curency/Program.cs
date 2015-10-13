using System;


namespace curency
{
    struct Currency
    {
        uint _dollars;
        ushort _cent;

        public Currency(uint dollars , ushort cents)
        {
            _dollars = dollars;
            _cent = cents;
        }

        public override string ToString()
           {
            	 return string.Format("${0}.{1,-2:00}" , _dollars , _cent);

           }
        public static explicit operator Currency(float value)
        {
            checked
            {
                uint dollars = (uint)value;
                ushort cents = (ushort)((value - dollars)*100);
                return new Currency(dollars, cents);
            }
            
        }
        public static implicit operator float(Currency value)
        {
            return value._dollars + (value._cent / 100.0f);
        }
        public static implicit operator Currency(uint value)
        {
            return new Currency(value , 0);
        }
        public static implicit operator uint(Currency value)
        {
            return value._dollars;
        }
        public static string GetCurrency()
        {
            return "US Dollar";
        }
    }

    class Program
    {
        delegate string GetAsString();
        static void Main()
        {
            Currency balance = new Currency(55, 50);

            GetAsString firstStringMethod = new GetAsString(balance.ToString);
            Console.WriteLine(firstStringMethod());

            firstStringMethod = Currency.GetCurrency;
            Console.WriteLine(firstStringMethod());

        }
    }
}
