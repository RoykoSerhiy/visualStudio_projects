using System;
using System.Collections.Generic;


namespace Dictionaryu
{
    class Program
    {
        static void DictionaryExample()
        {
            Dictionary<string, int> dr = new Dictionary<string, int>();
            dr["dr1"] = 12;
            dr.Add("dr2" , 22);
            dr.Add("dr3", 33);
            dr.Add("dr4", 44);

            dr["dr1"] = 11;
            Console.WriteLine("The Dictionary content: ");
            foreach(KeyValuePair<string , int> p in dr)
            {
                Console.WriteLine("{0} {1}" , p.Key , p.Value);
            }
            dr.Remove("dr4");
            try
            {
                dr.Add("dr1", 15);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(dr["dr5"]);
            }
            catch(Exception ex)
            {
                 Console.WriteLine(ex.Message);
            
            }
            int val;
            if (dr.TryGetValue("dr3", out val))
            {
                Console.WriteLine(val);
            }
            else
            {
                Console.WriteLine("Key not found");
            }


        }

        static void Main()
        {
            DictionaryExample();
        }
    }
}
