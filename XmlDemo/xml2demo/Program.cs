using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml;

using System.Linq;

namespace xml2demo
{
    class Program
    {
        class Contact
        {
            public string name { set; get; }
            public string phone { set; get; }
            public string email { set; get; }

            public override string ToString()
            {
                return name+" "+phone+" "+email;
            }

        }
        static void Main()
        {
            List<Contact> contacts = 
                (from c in XDocument.Load("contacts.xml").Root.Elements("contact")
                select new Contact
                {
                    name = (string)c.Element("name"),
                    phone = (string)c.Element("phone"),
                    email = (string)c.Element("email")
                }
    ).ToList();
            foreach(var c in contacts)
            {
                Console.WriteLine(c);
            }

                    
        }
    }
}
