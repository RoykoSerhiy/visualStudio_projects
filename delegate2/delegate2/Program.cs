using System;
using System.Collections;
delegate void MenuCallback();

namespace delegate2
{
    class MenuItem
    {
        public MenuCallback MC { set; get; }
        public string Text { set; get; }

        public MenuItem(string text, MenuCallback mc)
        {
            MC = mc;
            Text = text;
        }
    }
    class Menu
    {
        MenuItem [] items = new MenuItem[0];
        public string txt;
        public void Begin()
        {
            Console.WriteLine("Enter your chose");
            int choise = Convert.ToInt32(Console.ReadLine());
        }
        public  void Input()
        {
            txt = Console.ReadLine();
        }
        static void To_UpperCase(string str)
        {
            str.ToLower();
            Console.WriteLine(str);
        }
        static void To_LowerCase(string str)
        {
            str.ToUpper();
            Console.WriteLine(str);
        }
        public void Add(MenuItem element)
        {
            Console.WriteLine("Enter your text:");
            string str = Console.ReadLine();
            MenuCallback deleg = null;
            bool cycle = false;



            do
            {
                Console.WriteLine("Enter your chose: \n1.Upper\n2.Lower");
                int chose = Convert.ToInt32(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        {
                            deleg = To_UpperCase;
                            cycle = false;
                        }
                       break;
                    case 2:
                       {
                           deleg = To_LowerCase;
                           cycle = false
                       }
                        break;
                    default :
                        {
                            Console.WriteLine("Error;")
                                cycle = true;
                        }
                }

            } while (cycle == true);
             
        }
    }


    class Program
    {

       

        static void Main()
        {
            string txt = "aaasfdfgtgbhhyjuikolp";
           // MenuCallback m = To_LowerCase;
               //MenuItem  Menu = new MenuItem      
        }
    }
}
