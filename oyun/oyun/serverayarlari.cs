using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun
{
    internal class serverayarlari
    {
        public static string HOST { get; private set; }
        public static int PORT { get; private set; }
        public static void serversetting(string _host, int _port)
        {
            HOST = _host;
            PORT = _port;
        }

    }
}
