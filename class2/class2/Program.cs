using System;


namespace class2
{

    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction()
        {
            this._numerator = 1;
            this._denominator = 1;
        }

        public Fraction(int num, int denom)
        {
            if (denom == 0)
            {
                Console.WriteLine("Denominator can t be zer0");
                return;
            }
            else
            {
                this._numerator = num;
                this._denominator = denom;
            }
        }

        public Fraction(int num)
        {
            this._numerator = num;
            this._denominator = 1;
        }

        public override string ToString()
        {
            return (this._numerator +" / "+  this._denominator);
        }

        public static string operator * (Fraction f1, Fraction f2)
        {
            return (f1._numerator + "/" + f1._denominator + "*" + f2._numerator + "/" + f2._denominator + "=" +
                (f1._numerator*f2._numerator) +"/"+ (f1._denominator*f2._denominator));
        }
        public static string operator /(Fraction f1, Fraction f2)
        {
            return (f1._numerator + "/" + f1._denominator + "/" + f2._numerator + "/" + f2._denominator + "=" +
                (f1._numerator * f2._denominator) + "/" + (f1._denominator * f2._numerator));
        }
        public static string operator +(Fraction f1, Fraction f2)
        {
            int res_num1 = (f1._numerator * f2._denominator);
            int res_num2 = (f2._numerator * f1._denominator);
            int res_Denom = f1._denominator * f2._denominator;

            string res = (f1._numerator+"/"+f1._denominator + "+" +f2._numerator+"/"+f2._denominator +"="
                + res_num1+"/"+res_Denom+"+"+res_num2+"/"+res_Denom+"="
                +(res_num1+res_num2)+"/"+res_Denom);
            return res;
        }
        public static string operator -(Fraction f1, Fraction f2)
        {
            int res_num1 = (f1._numerator * f2._denominator);
            int res_num2 = (f2._numerator * f1._denominator);
            int res_Denom = f1._denominator * f2._denominator;

            string res = (f1._numerator + "/" + f1._denominator + "-" + f2._numerator + "/" + f2._denominator + "="
                + res_num1 + "/" + res_Denom + "-" + res_num2 + "/" + res_Denom + "="
                + (res_num1 - res_num2) + "/" + res_Denom);
            return res;
        }
        //public static string operator +(Fraction f1 , int a)
        //{
        //    return ((f1._numerator+a)+"/"+(f1._denominator+a));
        //}
        //public static string operator -(Fraction f1, int a)
        //{
        //    return ((f1._numerator - a) + "/" + (f1._denominator - a));
        //}
        public static string operator *(Fraction f1, int a)
        {
            return ((f1._numerator * a) + "/" + f1._denominator);
        }
        public static string operator /(Fraction f1, int a)
        {
            return (f1._numerator  + "/" + (f1._denominator* a));
        }
        public static string operator *(int a, Fraction f1)
        {
            return f1*a;
        }
        public static string operator /(int a , Fraction f1)
        {
            return f1/a;
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            int res_num1 = (f1._numerator * f2._denominator);
            int res_num2 = (f2._numerator * f1._denominator);
            int res_Denom = f1._denominator * f2._denominator;

            if (res_num1 == res_num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
           
            int res_num1 = (f1._numerator * f2._denominator);
            int res_num2 = (f2._numerator * f1._denominator);
            int res_Denom = f1._denominator * f2._denominator;
            
            if (res_num1 > res_num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            return !(f1>f2);   
        }


        //public static bool operator true(Fraction f1)
        //{
        //    if(f1._denominator > f1._numerator)
        //    {
        //      return true;   
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static bool operator false(Fraction f1)
        //{
        //    if (f1._denominator < f1._numerator)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        public string socr(Fraction f)
        {
            int x = (f._numerator < f._denominator) ? f._numerator : f._denominator;
            for (int i = 2; i < x; ++i)
            {
                if (f._numerator % i == 0 && f._denominator % i == 0)
                {
                    f._numerator /= i;
                    f._denominator /= i;
                }
            }
            return (f._numerator+"/"+f._denominator);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Fraction f1 = new Fraction(5, 10);
            Fraction f2 = new Fraction(3, 8);
            int num = 13;
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            //Console.WriteLine("--------f*f--------");
            Console.WriteLine(f1 * f2);
            //Console.WriteLine("--------f/f--------");
            Console.WriteLine(f1 / f2);
            //Console.WriteLine("--------f+f--------");
            Console.WriteLine(f1 + f2);
            //Console.WriteLine("--------f-f--------");
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1+" > "+f2+"?");
            Console.WriteLine(f1 > f2);
            Console.WriteLine(f1 + " < " + f2 + "?");
            Console.WriteLine(f1 < f2);
            Console.WriteLine(f1 + " == " + f2 + "?");
            Console.WriteLine(f1 == f2);
            Console.WriteLine(f1 + " != " + f2 + "?");
            Console.WriteLine(f1 != f2);


            Console.WriteLine(f1.socr(f1));
            //Console.WriteLine("--------f*a--------");
            //Console.WriteLine(f1 * num);
            //Console.WriteLine("--------f/a--------");
            //Console.WriteLine(f1 / num);
            //Console.WriteLine("--------f+a--------");
            //Console.WriteLine(f1 + num);
            //Console.WriteLine("--------f-a--------");
            //Console.WriteLine(f1 - num);

            //Console.WriteLine("---true or false---");
            
            //if (f1)
            //{
            //    Console.WriteLine("f1-true");
            //}
            //else
            //{
            //    Console.WriteLine("f1-false");
            //}
            //if (f2)
            //{
            //    Console.WriteLine("f2-true");
            //}
            //else
            //{
            //    Console.WriteLine("f2-false");
            //}
        }
    }
}
