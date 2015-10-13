using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;


namespace XmlWriterDemo
{
    class Program
    {
        class Employee
        {
            int id;
            string firstname;
            string lastname;
            int salary;

            public Employee(int _id, string fn, string ln, int sal)
            {
                id = _id;
                firstname = fn;
                lastname = ln;
                salary = sal;
            }
            public int Id { get { return id; } }
            public string FirstName { get { return firstname; } }
            public string LastName { get { return lastname; } }
            public int Salary { get { return salary; } }
        }
        static void Main()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee(1, "Vasya", "Pupkin", 10000);
            employees[1] = new Employee(2, "Petro", "Bubkin", 20000);
            employees[2] = new Employee(3, "Mykola", "Zupkin", 25000);
            employees[3] = new Employee(4, "Valera", "Bulkin", 40000);
            using (XmlWriter writer = XmlWriter.Create("employees.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Emoloyess");

                foreach (Employee em in employees)
                {
                    writer.WriteStartElement("Employee");

                    writer.WriteElementString("Id", em.Id.ToString());
                    writer.WriteElementString("Firstname", em.FirstName.ToString());
                    writer.WriteElementString("Id", em.ToString());
                    writer.WriteElementString("Salary", em.Salary.ToString());

                    writer.WriteEndElement();
                  
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

        }
    }
}
