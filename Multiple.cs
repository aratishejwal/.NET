using System;

namespace Multiple
{
    interface Idevice
    {
        string DeviceId { get; set; }
        string Name { get; set; }
        void TurnOn();
    }

    interface INetworkDevice
    {
        string IpAddress { get; set; }
        void Connect();
    }

    class SmartLight : Idevice, INetworkDevice
    {
        public string DeviceId { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }

        public SmartLight(string deviceId, string name, string ipAddress)
        {
            DeviceId = deviceId;
            Name = name;
            IpAddress = ipAddress;
        }

        public void TurnOn()
        {
            Console.WriteLine("{0} is turned on.", Name);
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to network at {0}", IpAddress);
        }

        public void SetBrightness(int level)
        {
            Console.WriteLine("Setting brightness of {0} to {1}.", Name, level);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a smart light object
            Console.WriteLine("Enter details of smart light: Device Id, Name, IP");
            string did = Console.ReadLine();
            string dname = Console.ReadLine();
            string dip = Console.ReadLine();
            Console.WriteLine("Enter Brightness Level:");
            int blevel = Convert.ToInt32(Console.ReadLine());
            SmartLight smartLight = new SmartLight(did, dname, dip);
            smartLight.TurnOn();
            smartLight.Connect();
            smartLight.SetBrightness(blevel);
        }
    }
}
