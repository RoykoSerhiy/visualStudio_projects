using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dlls
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load(AssemblyName.GetAssemblyName("Library.dll"));
            Module mod = asm.GetModule("Library.dll");
            Console.WriteLine("Оголошені типи даних:");
            foreach(Type t in mod.GetTypes())
                Console.WriteLine(t.FullName);
            Type Person = mod.GetType("Library.Person") as Type;
            object person = Activator.CreateInstance(Person, new object[] { "Ivan", "Ivanov", 20 });
            Person.GetMethod("Print").Invoke(person , null);
        }
    }
}
