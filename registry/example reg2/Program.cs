using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_reg2
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Registry.CurrentUser.Name,
            skey = "GetSetValue",
            skeyName = user + "\\" + skey;
            Registry.SetValue(skeyName,"",0x1234);
            Registry.SetValue(skeyName, "GSVQWord", 0x123456789ABCDEF, RegistryValueKind.ExpandString);
            Registry.SetValue(skeyName,"GSVString","Path: %path%");
            Registry.SetValue(skeyName, "GSVExpandString", "PtnPnh", RegistryValueKind.ExpandString);
            Registry.SetValue(skeyName,"GSVArray" ,new[]{"s1" , "s2" ,"s3"});
        }
    }
}
