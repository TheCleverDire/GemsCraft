using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft;
using fCraft.Utils;
using Newtonsoft.Json;
using static System.Net.Dns;

namespace fCraft.Network
{
    public class RemoteControl
    {
        //internal static HttpListener HttpListener = new HttpListener();
        // **** USE ABOVE LINE FOR CREATING THE MAP ****
        public static List<PlayerInfo> RegisteredPlayers = new List<PlayerInfo>();
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

        public static void LoadRegisteredPlayers()
        {
            if (!ConfigKey.OnTheGoEnabled.Enabled()) return;
            foreach (var player in PlayerDB.PlayerInfoList)
            {
                if (player.RemoteUserRegistered)
                {
                    RegisteredPlayers.Add(player);
                }
            }
        }

        internal static bool Login(string username, string password)
        {
            if (!ConfigKey.OnTheGoEnabled.Enabled()) return false;
            return RegisteredPlayers.Select(
                player => string.Equals(player.Name.ToLower(),
                                        username.ToLower())
                                        && password == player.RemotePassword.CalculateMd5Hash())
                                        .FirstOrDefault();
        }


        internal static bool Register(string username, string password)
        {
            if (!ConfigKey.OnTheGoEnabled.Enabled()) return false;
            var foundOne = false;
            Player pObj = null;
            foreach (var p in PlayerDB.PlayerInfoList)
            {
                foundOne = p.Name.ToLower() == username.ToLower();
                pObj = p.PlayerObject;
            }
            if (!foundOne) return false;
            if (pObj == null)
            {
                return false;
            }
            else
            {
                pObj.Info.RemotePassword = password.CalculateMd5Hash();
                pObj.Info.RemoteUserRegistered = true;
                LoadRegisteredPlayers(); // Reload registered players to get the new player in
                return true;
            }
        }

        internal static bool ChangePassword(string username, string oldpassword, string newpassword, out bool registered)
        {
            registered = false;
            if (!ConfigKey.OnTheGoEnabled.Enabled()) return false;
            if (oldpassword == newpassword) return false;
            var foundOne = false;
            Player pObj = null;
            foreach (var p in PlayerDB.PlayerInfoList)
            {
                foundOne = p.Name.ToLower() == username.ToLower();
                pObj = p.PlayerObject;
            }
            if (!foundOne) return false;
            if (pObj == null)
            {
                return false;
            }
            if (!pObj.Info.RemoteUserRegistered)
            {
                return false;
            }

            pObj.Info.RemotePassword = newpassword.CalculateMd5Hash();
            pObj.Info.RemoteUserRegistered = true;
            LoadRegisteredPlayers(); // Reload registered players to get the new player in
            registered = true;
            return true;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public static string DirectoryStr = "RemoteControl/";
        public static string RegisteredPlayerFile = DirectoryStr + "players.json";
        private static void Start(object port)
        {
            AllocConsole(); // Setting up for debug TODO: Remove when done
            if (!ConfigKey.OnTheGoEnabled.Enabled()) return;
            if (!Directory.Exists(DirectoryStr))
            {
                Directory.CreateDirectory(DirectoryStr);
            }
            LoadRegisteredPlayers();

            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                var server = new TcpListener(localAddr, (int)port);

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

                    var loopCount = 0;
                    string receivedUsername = "";
                    string receivedPassword = "";
                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                        if (loopCount == 0)
                        {
                            receivedUsername = data;
                            loopCount = 1;
                        }
                        else if (loopCount == 1)
                        {
                            receivedPassword = data;
                            loopCount = 2;
                        }
                        if (loopCount > 1)
                        {
                            if (receivedUsername == "") return;
                            if (receivedPassword == "") return;
                            PlayerInfo pi = null;
                            foreach (var p in RegisteredPlayers)
                            {
                                var px = RegisteredPlayers;
                                if (receivedUsername.ToLower() == p.Name.ToLower())
                                {
                                    pi = p;
                                }
                            }
                            if (pi == null)
                            {
                                msg = Encoding.ASCII.GetBytes("Sorry, that user doesn't exist.");
                            }
                            else
                            {
                                msg = Encoding.ASCII.GetBytes(
                                    receivedPassword.CalculateMd5Hash()
                                    != pi.RemotePassword
                                    ? "Password is not correct."
                                    : "Login Successful");
                            }

                            string[] dataWords = data.GetWords();
                            foreach (var d in dataWords)
                            {
                                Console.WriteLine("Word: " + d);
                            }
                        }
                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", data);
                    }

                    // Shutdown and end connection
                    //client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                //server.Stop();
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

        static string message =
                "Warning: Changes may not take effect until next server restart. For some, you can use /reload config";
        /// <summary>
        /// Allows user to modify config items
        /// </summary>
        /// <param name="configName">Config Name</param>
        /// <param name="value">Value to set</param>
        /// <returns>Returns true if was successful</returns>
        public static bool EditConfigItem(PlayerInfo pInfo, string configItem, object value, out string output)
        {
            output = message;
            var foundOne = false;
            foreach (var configSection in Config.ConfigSections)
            {
                foreach (var configKey in configSection.GetKeys())
                {
                    if (configItem != configKey.ToString("G").ToLower()) continue;
                    output =
                        configKey.TrySetValue(value)
                            ? message
                            : "Error: Inappropiate format entered for config value. Please double check.";
                    foundOne = true;
                }
            }
            if (!foundOne)
            {
                output = "Config item doesn't exit. Check your spelling: " + configItem;
                return false;
            }
            else
            {
                Config.Save();
                return true;
            }
        }
    }
}
