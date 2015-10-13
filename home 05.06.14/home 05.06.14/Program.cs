using System;


public class Equation
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    public Equation(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c; 
    }
    public override string ToString()
    {
        return A + " * X +" + B + " * y + " + C +" = 0";
    }
}
public class SysEquation
{
    private Equation _eq1;
    private Equation _eq2;


    public int X { set; get; }
    public int Y { set; get; }

    public SysEquation(int a1, int b1, int a2, int b2 , int c1 , int c2)
    {
        _eq1 = new Equation(a1, b1 ,c1);
        _eq2 = new Equation(a2, b2 , c2);
        Solution();
    }

    public SysEquation(Equation eq1, Equation eq2)
    {
        _eq1 = eq1;
        _eq2 = eq2;
        Solution();
    }


    public override string ToString()
    {
        return _eq1.ToString() + "/n" +
            _eq2.ToString();
    }

    public void Solution()
    {
        if (_eq2.A / _eq2.B - _eq1.A / _eq1.B == 0 || _eq2.B == 0)
        {
            throw new Exception("there are no solutions");
        }

        X = (_eq1.C / _eq1.B - _eq2.C / _eq2.B)/(_eq2.A/_eq2.B - _eq1.A / _eq1.B);
        Y = (-_eq2.C - _eq2.A * X) / _eq2.B;
    }


}



    class Program
    {
        static void Main()
        {
            Equation eq1 = new Equation(1,-1,5);
            Equation eq2 = new Equation(2,1,7);

            try
            {
                SysEquation sys1 = new SysEquation(eq1, eq2);
                Console.WriteLine("x = " + sys1.X + " y = " + sys1.Y);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

