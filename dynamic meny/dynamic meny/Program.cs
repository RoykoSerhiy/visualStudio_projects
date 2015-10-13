using System;
using System.Collections;
delegate void MenuCallBack();

namespace dynamic_meny
{
    class MenuItem
    {
        public MenuCallBack MC{set;get;}
        public string Text { set; get; }

        public MenuItem(string txt , MenuCallBack mc)
            {
               MC= mc;
               Text = txt;
            }

    }
    class Menu
    {
        ArrayList menu = new ArrayList();

        public void Add(string str, MenuCallBack mc)
        {
            menu.Add(new MenuItem(str , mc));
        }
        public void Show()
        {
            for (int i = 0; i < menu.Count; ++i)
            {
                MenuItem item = menu[i] as MenuItem;
                Console.WriteLine(item.Text);
            }
        }
        public void Run()
        {
            Console.Write("Please enter choise: ");
            int choise = Int32.Parse(Console.ReadLine());

            if (choise >= 1 && choise <= menu.Count)
            {
                MenuItem mItem = menu[choise - 1] as MenuItem;
                mItem.MC.Invoke();
            }
        }


    }
    class Program
    {
        static void Main()
        {
            Menu menu = new Menu();
            menu.Add("[1] To Upper Case", ToUpperCase);
            menu.Add("[2] To Lower Case", ToLowerCase);
            menu.Show();
            menu.Run();
        }

        static void ToUpperCase()
        {
            string str;
            Console.WriteLine("Please enter text: ");
            str = Console.ReadLine();
            Console.WriteLine(str.ToUpper());
        }
        static void ToLowerCase()
        {
            string str;
            Console.WriteLine("Please enter text: ");
            str = Console.ReadLine();
            Console.WriteLine(str.ToLower());
        }
    }
}
