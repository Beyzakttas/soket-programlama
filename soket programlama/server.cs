using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Configuration;

namespace soket_programlama
{
    internal class server
    { 
     public static int maxplayers { get; private set; }
    public static int port { get; private set; }
    public static TcpListener serverListener;
        public static SortedDictionary<int, Client> clients = new SortedDictionary<int, Client>();// 4 tane oyuncu katılabilir
        private static  object clinets;

        public static void Setupserver(int _maxplayers,int _port) {
            maxplayers = _maxplayers;
            port = _port;
            clientKur();
            serverListener = new TcpListener(IPAddress.Any, port);
            Console.WriteLine($"server kuruldu:max oyuncu sayisi :{maxplayers }");
        }
        public static void startserver()
        {
            serverListener.Start();
            Console.WriteLine($"{port}unda dinleniyor");
            serverListener.BeginAcceptTcpClient(AcceptClientCallBack , null);
            Console.WriteLine("kullanicilar bekleniyor ");
        }
            public static void AcceptClientCallBack(IAsyncResult asyncResult)
        {
            TcpClient  soket=   serverListener.EndAcceptTcpClient(asyncResult);
            serverListener.BeginAcceptTcpClient(AcceptClientCallBack, null);
            Console.WriteLine("kullanici katılıyor");
           for (int i = 1; i <= clients.Count; i++)// dolu mu bos mu kontrol edecek
            {
                if (clients[i].tcp.soket ==null)
                {
                    clients[i].tcp.Connect(soket);
                    return;
                }
            }
            soket.Close();
            Console.WriteLine("kullanici katilamadi.Server dolu");

        }
        public static void clientKur()
        {
         for (int i = 1; i <= maxplayers; i++)
            {
                clients.Add(i, new Client(i));

            }
        }

    }
}
