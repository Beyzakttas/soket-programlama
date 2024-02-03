using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace oyun
{
    internal class Client
    {
        public static TcpClient soket = new TcpClient();
        public static void Connect()
        {
            soket .BeginConnect(serverayarlari.HOST, serverayarlari.PORT, new AsyncCallback(ConnectCallBack), null);
            Console.WriteLine("baglanılıyor");
        }
        public static void ConnectCallBack(IAsyncResult asyncResult)
        {
            soket.EndConnect(asyncResult);
            if (soket.Connected) { 
            Console.WriteLine("baglanıldı");
        }
        }
    }
}
