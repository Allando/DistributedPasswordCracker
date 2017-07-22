using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CC");




            #region UdpClient
            int number = 0;

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 9999;
            UdpClient udpClient = new UdpClient("127.0.0.1", port);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, port);
            //udpClient.Connect(RemoteIpEndPoint); 

            List<IPEndPoint> EndPointList = new List<IPEndPoint>
            {
                RemoteIpEndPoint
            };

            Console.WriteLine(EndPointList.Count);

            Console.Write("State name: ");
            String name = Console.ReadLine();

            for (int i = 0; i < 5000; i++)
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes(name + " " + number + " hello");

                udpClient.Send(sendBytes, sendBytes.Length); //, RemoteEndPoint);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                //Client is now activated");

                string receivedData = Encoding.ASCII.GetString(receiveBytes);
                Console.WriteLine(receivedData);
                number++;

                Thread.Sleep(100);
            } 
            #endregion
        }
    }
}
