using CourceWord.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Document_Class dc = new Document_Class();
               // dc.CreateDocument(@"E:\testDoc.doc");
                dc.OpenDocument(@"E:\testDoc.doc");
                dc.SetText("gfjnbhbutu");
                //dc.SaveDocument();
                Console.WriteLine(dc.GetText());
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
