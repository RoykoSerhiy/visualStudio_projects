using System;


namespace class2
{
    class Equation
    {
        public int A { set; get; }
        public int B { set; get; }

        public Equation()
        {
            A = 1;
            B = 1;
        }
        public Equation(int a, int b)
        {
            A = a;
            B = b;
        }

        public override string ToString()
        {
            return A + " * X + " + B + " * Y = 0";
        }

        public static Equation Parse(string str)
        {
            try
            {
                if (str.IndexOf(",") != -1)
                {
                    while (str.IndexOf(" ") != -1)
                    {
                        str = str.Replace(" ", "");
                    }
                }
                else
                if(str.IndexOf("  ") != -1)
                {
                    while (str.IndexOf("  ") != -1)
                    {
                        str = str.Replace("  ", " ");
                    }
                }
                else
                    if (str.IndexOf(" ") != -1)
                    {
                        while (str.IndexOf("/") != -1)
                        {
                            str = str.Replace(" ", "");
                        }
                    }
                char[] sep = { ' ', ',' };
                string[] res = str.Split(sep);

                //if (!isInt(sep[0]) || !isInt(res[1]))
                
             if (!Char.IsNumber(res[0][0]) || !Char.IsNumber(res[1][0]))
                {
                    throw new FormatException("is not a nuber");
                }
                else
                {
                    int a = Convert.ToInt32(res[0]);
                    int b = Convert.ToInt32(res[1]);

                    return new Equation(a,b);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return new Equation();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Equation();
            }
            catch
            {
                Console.WriteLine("Unknown error");
                return new Equation();
            }
        }

        public static bool isInt(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }

    class Program
    {
        
        static void Main()
        {

            //Equation.Parse("1f1               ,               222");
            Equation eq1 = Equation.Parse("111 ,    2222");
            Console.WriteLine(eq1.ToString());
        }
    }
}
