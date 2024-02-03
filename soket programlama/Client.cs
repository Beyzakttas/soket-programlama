using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace soket_programlama
{
    internal class Client
    {
        public int id;
        public TCP tcp;
        public Client (int _id)
        {
            id = _id;
            tcp = new TCP(id);
        }
        public class TCP
        {
            public TcpClient soket;
            public readonly  int id;
            public TCP(int _id)
            {
                id = _id;
            }
            public void Connect(TcpClient _soket)
            {
                soket = _soket;
                Console.WriteLine($"baglanti gerceklestirildi:{id}");
            }
        }
    }
}
