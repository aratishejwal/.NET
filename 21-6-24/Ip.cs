using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        // Get the host name of the local machine
        string hostName = Dns.GetHostName();
        Console.WriteLine("Host Name: " + hostName);

        // Get the IP addresses associated with the host name
        IPAddress[] addresses = Dns.GetHostAddresses(hostName);

        // Display each IP address
        foreach (IPAddress address in addresses)
        {
            Console.WriteLine("IP Address: " + address.ToString());
        }
    }
}
