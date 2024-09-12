// See https://aka.ms/new-console-template for more information

using System.Net.Sockets;
using System.Text;

Console.WriteLine("UDP Client");

using (UdpClient socket = new UdpClient())
{
    while (true)
    { 
    string message = Console.ReadLine();
    byte[] data = Encoding.UTF8.GetBytes(message);
    socket.Send(data, data.Length, "127.0.0.1", 5005);
    }

}
