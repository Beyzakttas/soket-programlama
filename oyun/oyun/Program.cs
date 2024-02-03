using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace oyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            serverayarlari.serversetting("127.0.0.1", 8585);
            Client.Connect();
            Console.ReadKey();
        }
    }
}
