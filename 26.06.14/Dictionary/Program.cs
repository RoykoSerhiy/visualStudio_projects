using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace Dictionary
{

    class Diction
    {
       
        
    }
        
       
    
    class Program
    {
        static void Main()
        {
            
            Dictionary<string, string> Dict = new Dictionary<string, string>();
       
            Dict.Add("Kiev", "Київ");
            Dict.Add("Ukraine", "Україна");
            Dict.Add("Rivne", "Рівне");
            Dict.Add("USA", "США");

            string str;
            Console.WriteLine("Enter word/Введіть слово");
            str = Console.ReadLine();

            if(Dict.ContainsValue(str))
            {
                foreach (KeyValuePair<string, string> kv in Dict)
                {
                    if (kv.Value == str)
                    {
                        Console.WriteLine("---------------");

                        Console.WriteLine(kv.Key);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dont have word/Нема такого слова!!!");
                        break;
                    }
                }

           }
            if (Dict.ContainsKey(str))
            {
                foreach (KeyValuePair<string, string> kv in Dict)
                {
                    if (kv.Key == str)
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine(kv.Value);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dont have word/Нема такого слова!!!");
                        break;
                    }

                }
            }
            
        }
    }
}
