using CourceWord_dll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace CourceWord_WindowsService
{
    public partial class Service1 : ServiceBase
    {
        internal static ServiceHost host = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (host != null)
            {
                host.Close();
            }

            host = new ServiceHost(typeof(CourceWordService));
            host.Open(); 
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Close();
                host = null;
            } 
        }
    }
}
