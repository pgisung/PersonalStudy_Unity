using ServerCore;
using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;

namespace DummyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DNS (Domain Name System)
            string host = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostEntry(host);
            IPAddress ipAddr = ipHost.AddressList.First();
            IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);

            Connector connector = new Connector();
            connector.Connect(endPoint,
                () => { return SessionManager.Instance.Generate(); },
                200);

            while(true)
            {
                try
                {
                    SessionManager.Instance.SendForEach();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} Exception Occured: " + ex.ToString());
                }

                Thread.Sleep(250);
            }
        }
    }
}