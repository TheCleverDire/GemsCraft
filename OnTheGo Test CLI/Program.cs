using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OnTheGo_Test_CLI
{
    class Program
    {

        private static readonly List<string> Questions = new List<string>
        {
            "Enter your username", "Enter your password"
        };

        private static void InitQuestion(int question, TcpClient tcpclnt)
        {
            Console.WriteLine(Questions[question] + ": ");

            String str = Console.ReadLine();
            Stream stm = tcpclnt.GetStream();

            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(str);
            Console.WriteLine("Transmitting.....");

            stm.Write(ba, 0, ba.Length);

            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            for (int i = 0; i < k; i++)
                Console.Write(Convert.ToChar(bb[i]));
           
        }

        private static void InitTest(TcpClient tcpclnt)
        {
            Stream stm = tcpclnt.GetStream();

            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes("editconfig servername CLITestFunction");
            Console.WriteLine("Transmitting.....");

            stm.Write(ba, 0, ba.Length);

            byte[] bb = new byte[100];
            int k = stm.Read(bb, 0, 100);

            for (int i = 0; i < k; i++)
                Console.Write(Convert.ToChar(bb[i]));
        }
        static void Main(string[] args)
        {
            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpclnt.Connect("localhost", 65509);
                // use the ipaddress as in the server program

                Console.WriteLine("Connected");
                
                for (var q = 0; q <= Questions.Count - 1; q++)
                {
                    InitQuestion(q, tcpclnt);
                }
                InitTest(tcpclnt);
                tcpclnt.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.ToString());
            }
            Console.ReadLine();
        }
    }
    
}
