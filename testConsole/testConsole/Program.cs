using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Messaging;

namespace testConsole
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            foreach (ManagementObject hdd in searcher.Get())
            {
                Console.WriteLine(hdd["SerialNumber"]);
            }
        }
    }
}
