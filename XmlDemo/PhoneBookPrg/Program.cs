using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using System.Collections;

namespace PhoneBookPrg
{

    class Program
    {
        class PhoneBook
        {
            public string name;
            public string phone;
            public string adress;  
            public string birthday;
            public string email;

            public PhoneBook(string n, string p, string a, string birth, string e)
            {
                name = n;
                phone = p;
                adress = a;
                birthday = birth;
                email = e;
            }
            public PhoneBook()
            {
            }
            //public override string ToString()
            //{
            //    return name+" "+phone+"\n"+adress+" "+birthday+"\n"+email;
            //}
            public string Name { get { return name; } set { name = value; } }
            public string Phone { get { return phone; } set { phone = value; } }
            public string Adress { get { return adress; } set { adress = value; } }
            public string Birthday { get { return birthday; } set { birthday = value; } }
            public string Email { get { return email; } set { email = value; } }
        }
        static void ReCreate(ArrayList d)
        {
            PhoneBook book = new PhoneBook();
            using (XmlReader reader = XmlReader.Create("XMLFile1.xml"))
            {
                while (reader.Read())
                {
        
                    if (reader.IsStartElement())
                    {
                        
                        switch (reader.Name)
                        {
        
        
                            case "name":
                                {
                                    book.Name = reader.ReadString();
                                } break;
                            case "phone":
                                {
                                    book.Phone = reader.ReadString();
                                } break;
                            case "adress":
                                {
                                    book.Adress = reader.ReadString(); 
                                } break;
                            case "birthday":
                                {
                                    book.Adress = reader.ReadString();
                                } break;
                            case "email":
                                {
                                    book.Email = reader.ReadString();
                                    d.Add(book);
                                } break;
                            
                        }
                        
                    }
        
                }
        
        
            } 
        }

        static void Add(ArrayList listpb)
        {
            using (XmlWriter writer = XmlWriter.Create("XMLFile1.xml"))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("contacts");
                //ArrayList d = new ArrayList();
                foreach(PhoneBook list in listpb)
                {
                    writer.WriteStartElement("contact");
                    writer.WriteElementString("name" , list.Name);
                    writer.WriteElementString("phone", list.Phone);
                    writer.WriteElementString("adress", list.Adress);
                    writer.WriteElementString("birthday", list.Birthday);
                    writer.WriteElementString("email", list.Email);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            //listpb.Add(pb);
        }
        static void Remove(ArrayList dir , PhoneBook pb)
        {
            try
            {
                for (int i = 0; i < dir.Count; ++i)
                {
                    if (dir[i] == pb)
                    {
                        dir.RemoveAt(i);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //static void Clear();
        //static void Edit();
        static void Show()
        {
            using (XmlReader reader = XmlReader.Create("XMLFile1.xml"))
            {
                while (reader.Read())
                {
                    
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                          

                            case "name":
                                {
                                    
                                    Console.WriteLine("name: " + reader.ReadString());
                                    
                                } break;
                            case "phone":
                                {
                                    Console.WriteLine("phone: " + reader.ReadString());
                                } break;
                            case "adress":
                                {
                                    Console.WriteLine("adress: " + reader.ReadString());
                                }break;
                            case "birthday":
                                {
                                    Console.WriteLine("birthday: " + reader.ReadString());
                                }break;
                            case "email":
                                {
                                    Console.WriteLine("email: " + reader.ReadString());
                                } break;
                            default:
                                {
                                    Console.WriteLine("-----------------");
                                }break;
                        }
                        
                    }
                   
                }
                

            } 
        }
        static void Search(ArrayList dir)
        {
            try
            {
            Console.WriteLine("enter for search");
            string str = Console.ReadLine();
            foreach (PhoneBook pb in dir)
            {
                if (pb.Name.IndexOf(str) != -1)
                {

                    Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);

                    Console.WriteLine("1.Remove  2.Edit");
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            {
                                Remove(dir, pb);
                            } break;
                        default:
                            {
                                continue;
                            }
                    }

                }
                else if (pb.Phone.IndexOf(str) != -1)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);

                    Console.WriteLine("1.Remove  2.Edit");
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            {
                                Remove(dir, pb);
                            } break;
                        default:
                            {
                                continue;
                            }
                    }
                }
                else if (pb.Adress.IndexOf(str) != -1)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);

                    Console.WriteLine("1.Remove  2.Edit");
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            {
                                Remove(dir, pb);
                            } break;
                        default:
                            {
                                continue;
                            }
                    }
                }
                else if (pb.Birthday.IndexOf(str) != -1)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);

                    Console.WriteLine("1.Remove  2.Edit");
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            {
                                Remove(dir, pb);
                            } break;
                        default:
                            {
                                continue;
                            }
                    }
                }
                else if (pb.Email.IndexOf(str) != -1)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);

                    Console.WriteLine("1.Remove  2.Edit");
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            {
                                Remove(dir, pb);
                            } break;
                        default:
                            {
                                continue;
                            }
                    }
                }
            }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                    
                
            
            //return new PhoneBook("", "", "", "", "");

        }
                

        static void Main()
        {
            try
            {
                ArrayList pb = new ArrayList();
                ReCreate(pb);
                //PhoneBook el1 = new PhoneBook("Kot" , "52-69-32" , "box" , "03.25.2001" , "kotFromHell@gmail.com");

                bool is_menu = true;
                while (is_menu)
                {
                    Console.WriteLine("1.Add , 2.Show , 3.Search(remove ,edit) , 0.Exit");
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter Name:");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter Phone:");
                                string phone = Console.ReadLine();
                                Console.WriteLine("Enter Adress:");
                                string adress = Console.ReadLine();
                                Console.WriteLine("Enter Birthday:");
                                string birth = Console.ReadLine();
                                Console.WriteLine("Enter Email:");
                                string email = Console.ReadLine();
                                pb.Add(new PhoneBook(name, phone, adress, birth, email));
                                Add(pb);
                            } break;

                        case 2:
                            {
                                try
                                {
                                    Show();
                                }
                                catch
                                {
                                    Console.WriteLine("File is empty!!!");
                                }
                            } break;

                        case 3:
                            {
                                Search(pb);
                            } break;

                        case 0:
                            {
                                is_menu = false;
                            } break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
