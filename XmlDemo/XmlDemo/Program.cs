using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;


namespace XmlDemo
{
    class Program
    {
        static void Main()
        {
            //XElement element = XElement.Load("XMLFile1.xml");
            //Console.WriteLine(element.Value);

            XmlDocument document = new XmlDocument();
            document.Load("XMLFile1.xml");
           // document.Save(Console.Out);
            var root = document.DocumentElement;
            if (root != null)
            {
                var contacts = root.SelectNodes("contact");
                if (contacts != null)
                {
                    foreach(XmlNode c in contacts)
                    {
                        Console.Write(
                            c.SelectSingleNode("name").InnerText + " ");
                        Console.Write(c.SelectSingleNode("phone").InnerText + " ");
                        Console.WriteLine(c.SelectSingleNode("email").InnerText + " ");
                    }
                }
            }
        }
    }
}
