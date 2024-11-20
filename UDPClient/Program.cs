// Se https://aka.ms/new-console-template for mere information

using System.Net.Sockets;
using System.Text;

Console.WriteLine("UDP Client");

using (UdpClient socket = new UdpClient())
{
    while (true)
    {
        // Læs besked fra konsollen
        string message = Console.ReadLine();

        // Konverter besked til byte array
        byte[] data = Encoding.UTF8.GetBytes(message);

        // Send data til serveren på IP-adresse 127.0.0.1 og port 5005
        socket.Send(data, data.Length, "127.0.0.1", 5005);
    }
}
