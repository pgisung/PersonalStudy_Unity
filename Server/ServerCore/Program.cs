using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DNS (Domain Name System)
            string host = Dns.GetHostName();
            IPHostEntry ipHost =  Dns.GetHostEntry(host);
            IPAddress ipAddr = ipHost.AddressList.First();
            IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);

            Socket listenSocket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listenSocket.Bind(endPoint);

                // backlog : 최대 대기수
                listenSocket.Listen(10);

                while (true)
                {
                    Console.WriteLine("Listening...");

                    Socket clientSocket = listenSocket.Accept();

                    // 받는다
                    byte[] recvBuff = new byte[1024];
                    int recvBytes = clientSocket.Receive(recvBuff);
                    string recvData = Encoding.UTF8.GetString(recvBuff, 0, recvBytes);
                    Console.WriteLine($"[From Client] {recvData}");

                    // 보낸다
                    byte[] sendBuff = Encoding.UTF8.GetBytes("Welcome to MMORPG Sever");
                    clientSocket.Send(sendBuff);

                    // 닫는다
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}