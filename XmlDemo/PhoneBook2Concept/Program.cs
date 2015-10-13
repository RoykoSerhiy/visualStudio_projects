using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;


namespace PhoneBook2Concept
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
        static void Load(List<PhoneBook> l)
        {
            string name = "";
            string phone = "";
            string adress = "";
            string birthday = "";
            string email = "";
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
                                    Console.WriteLine("<contacts> load");
                                } break;

                            case "contact":
                                {
                                    Console.WriteLine("<conatct> load");
                                } break;
                            case "name":
                                {
                                    name = reader.ReadString();
                                } break;
                            case "phone":
                                {
                                    phone = reader.ReadString();
                                } break;
                            case "adress":
                                {
                                    adress = reader.ReadString();
                                } break;
                            case "birthday":
                                {
                                    birthday = reader.ReadString();
                                } break;
                            case "email":
                                {
                                   email = reader.ReadString();
                                   l.Add(new PhoneBook(name , phone , adress , birthday , email));
                                   // Save(l);
                                } break;

                        }

                    }

                }


            }
        }
        static void Save(List<PhoneBook> l)
        {
            using (XmlWriter writer = XmlWriter.Create("contacts.xml"))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("contacts");
                //ArrayList d = new ArrayList();
                foreach (PhoneBook list in l)
                {
                    writer.WriteStartElement("contact");
                    writer.WriteElementString("name", list.Name);
                    writer.WriteElementString("phone", list.Phone);
                    writer.WriteElementString("adress", list.Adress);
                    writer.WriteElementString("birthday", list.Birthday);
                    writer.WriteElementString("email", list.Email);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        static void Show(List<PhoneBook> l)
        {
            try
            {
                foreach (PhoneBook p in l)
                {
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.Phone);
                    Console.WriteLine(p.Adress);
                    Console.WriteLine(p.Birthday);
                    Console.WriteLine(p.Email);
                    Console.WriteLine("---------------------");
                }
            }
            catch
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File Empty:(");
            }
        }
        static void Search(List<PhoneBook> l)
        {
            try
            {
                Console.WriteLine("Enter Data For Search:");
                string str = Console.ReadLine();
                foreach (PhoneBook pb in l)
                {
                    if (pb.Name.IndexOf(str) != -1)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);
                        try
                        {
                            Console.WriteLine("1.Remove  2.Edit  0.Next");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {
                                case 1:
                                    {
                                        Remove(l, pb);
                                        Save(l);
                                    } break;
                                case 2:
                                    {
                                        Edit(l, pb);
                                        Save(l);
                                    }break;
                                default:
                                    {
                                        continue;
                                    }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (pb.Phone.IndexOf(str) != -1)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);
                        try
                        {
                            Console.WriteLine("1.Remove  2.Edit  0.Next");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {
                                case 1:
                                    {
                                        Remove(l, pb);
                                        Save(l);
                                    } break;
                                case 2:
                                    {
                                        Edit(l, pb);
                                        Save(l);
                                    } break;
                                default:
                                    {
                                        continue;
                                    }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (pb.Adress.IndexOf(str) != -1)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);
                        try
                        {
                            Console.WriteLine("1.Remove  2.Edit  0.Next");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {
                                case 1:
                                    {
                                        Remove(l, pb);
                                        Save(l);
                                    } break;
                                case 2:
                                    {
                                        Edit(l, pb);
                                        Save(l);
                                    } break;
                                default:
                                    {
                                        continue;
                                    }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (pb.Birthday.IndexOf(str) != -1)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);
                        try
                        {
                            Console.WriteLine("1.Remove  2.Edit  0.Next");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {
                                case 1:
                                    {
                                        Remove(l, pb);
                                        Save(l);
                                    } break;
                                case 2:
                                    {
                                        Edit(l, pb);
                                        Save(l);
                                    } break;
                                default:
                                    {
                                        continue;
                                    }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (pb.Email.IndexOf(str) != -1)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", pb.Name, pb.Phone, pb.Adress, pb.Birthday, pb.Email);
                        try
                        {
                            Console.WriteLine("1.Remove  2.Edit  0.Next");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {
                                case 1:
                                    {
                                        Remove(l, pb);
                                        Save(l);
                                    } break;
                                case 2:
                                    {
                                        Edit(l, pb);
                                        Save(l);
                                    } break;
                                default:
                                    {
                                        continue;
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Remove(List<PhoneBook> dir, PhoneBook pb)
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
            catch (Exception ex)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine(ex.Message);
            }
        }
        static void Edit(List<PhoneBook> l, PhoneBook pb)
        {
            try
            {
                for (int i = 0; i < l.Count; ++i)
                {
                    if (l[i] == pb)
                    {
                        
                        Console.WriteLine("Enter New Name:");

                        string name = Console.ReadLine();
                       
                        Console.WriteLine("Enter New Phone:");
                        string phone = Console.ReadLine();
                        Console.WriteLine("Enter New Adress:");
                        string adress = Console.ReadLine();
                        Console.WriteLine("Enter New Birthday:");
                        string birth = Console.ReadLine();
                        Console.WriteLine("Enter New Email:");
                        string email = Console.ReadLine();
                        Remove(l, pb);
                        l.Add(new PhoneBook(name, phone, adress, birth, email));
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine(ex.Message);
            }
        }
        static void Clear(List<PhoneBook> l)
        {
            l.Clear();
        }
        static void Main()
        {

            try
            {
                List<PhoneBook> list = new List<PhoneBook>();
                
                //PhoneBook el1 = new PhoneBook("Kot" , "52-69-32" , "box" , "03.25.2001" , "kotFromHell@gmail.com");
                Load(list);
                bool is_menu = true;
                while (is_menu)
                {
                    Console.WriteLine("1.Add , 2.Show , 3.Search(remove ,edit), 4.Clear ,5.Extra Save, 0.Exit");
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
                                list.Add(new PhoneBook(name, phone, adress, birth, email));
                                Console.WriteLine("Element Added");
                                //Save(list);
                            } break;

                        case 2:
                            {
                                try
                                {
                                    //Load(list);
                                    Show(list);
                                }
                                catch
                                {
                                    Console.WriteLine("File is empty!!!");
                                }
                            } break;

                        case 3:
                            {
                                Search(list);
                            } break;
                        case 4:
                            {
                                Clear(list);
                                
                                Console.WriteLine("Cleared");
                                Save(list);
                            }break;
                        case 5:
                            {
                                Save(list);
                                Console.WriteLine("Saved");
                            }break;
                        case 0:
                            {
                                Console.WriteLine("You want save book\n1.Yes,2.No");
                                int c = Convert.ToInt32(Console.ReadLine());
                                if (c == 1)
                                {
                                    Save(list);
                                    Console.WriteLine("Save Complete");
                                    is_menu = false;
                                }
                                else if( c == 2)
                                {
                                    is_menu = false;
                                }
                            } break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
        }

    }
}