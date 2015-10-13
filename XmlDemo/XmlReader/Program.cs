using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;


namespace XmlReaderDemo
{
    class Program
    {
        static void Main()
        {
            using (XmlReader reader = XmlReader.Create("contacts.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "contacts":
                                {
                                    Console.WriteLine("start <conatcts> element");
                                }break;

                            case "contact":
                                {
                                    Console.WriteLine("start <conatct> element");
                                } break;

                            case "name":
                                {
                                    string attr = reader["status"];

                                    Console.WriteLine("name: " + reader.ReadString());
                                    if (attr != null)
                                    {
                                        Console.WriteLine(" has attribute: {0}", attr);
                                    }
                                } break;
                            case "phone":
                                {
                                    Console.WriteLine("phone: " + reader.ReadString());
                                } break;
                            case "email":
                                {
                                    Console.WriteLine("email: " + reader.ReadString());
                                } break;

                        }

                    }
                }

            }
        }
    }
}
