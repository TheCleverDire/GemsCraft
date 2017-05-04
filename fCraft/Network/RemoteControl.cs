using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft;
using static System.Net.Dns;

namespace fCraft.Network
{
    public class RemoteControl
    {
        //internal static HttpListener HttpListener = new HttpListener();
        // **** USE ABOVE LIVE FOR CREATING THE MAP ****

        public static void StartRemoteServer()
        {
            try
            {
                Logger.Log(LogType.SystemActivity, "Starting the Remote Control Server...");
                var port = ConfigKey.OnTheGoPort.GetInt();
                Logger.Log(LogType.SystemActivity, "Remote Control Server started on IP: " + GetExternalIp() + ":" + port);
                Thread ts = new Thread(Start);
                ts.Start(port);

            }
            catch (Exception ex)
            {
                Logger.Log(LogType.SystemActivity, ex.ToString());
            }
        }

        private static void Start(object port)
        {
            TcpListener server = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, (int) port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        msg = Encoding.ASCII.GetBytes(
                            data != ConfigKey.OnTheGoPassword.GetString() 
                            ? "Sorry, the password is not correct."
                            : "Connected to remote control!");
                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }


            Console.WriteLine("\nHit enter to continue...");
            Console.Read();


        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
        private static string GetExternalIp()
        {
            try
            {
                IPHostEntry IPHost = GetHostByName(GetHostName());
                return IPHost.AddressList[0].ToString();
            }
            catch
            {
                return null;
            }
        }
    }
}
