using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace firstAppInMVC.Core
{
    public static class Storage
    {
        static Storage()
        {
            DbKey = "RegisteredUserList";
        }
        public static string DbKey { get; private set; }

    }
}