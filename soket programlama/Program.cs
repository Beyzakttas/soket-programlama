using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace soket_programlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            server.Setupserver(4,8585);// max 4 oyuncu girebilir
            server.startserver();
            Console.ReadKey();
        }
    }
}
