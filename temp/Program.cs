using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace temp
{
    class Program
    {
        Socket server;
        static void Main(string[] args)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            byte[] msg = Encoding.UTF8.GetBytes("This is a test");
            byte[] bytes = new byte[256];
            try
            {
                // Blocks until send returns. 
                int i = server.Send(msg);
                Console.WriteLine("Sent {0} bytes.", i);

                // Get reply from the server.
                i = server.Receive(bytes);
                Console.WriteLine(Encoding.UTF8.GetString(bytes));
            }
            catch (SocketException e)
            {
                Console.WriteLine("{0} Error code: {1}.", e.Message, e.ErrorCode);
            }
            Console.Read();
        }
    }
}
