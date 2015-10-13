using System;

namespace kalk
{
    delegate void Action(double n1 , double n2);
    class Program
    {
        static void Main()
        {

          
            kalk clk = new kalk(3, 2.5);
            Action action = new Action(clk.Plus);
            //action(9.3 , 7.7);
            action += clk.Minus;
            action += clk.Multi;
            action += clk.Div;
            action(3.3, 7.3);
           
        }
    }
}
