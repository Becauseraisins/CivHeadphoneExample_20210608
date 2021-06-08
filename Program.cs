using System;
using CivHeadphoneExample_20210608.models;

namespace CivHeadphoneExample_20210608
{
    class Program
    {
        static void Main(string[] args)
        {
            Cable copperCable = new Cable("Copper", "3.5mm", 1000);

            Wired mx50 = new Wired("MX50", 250, "Closed-Back", false, 15000, "2.5mm", copperCable);
            Wired h340 = new Wired("Logitech H340", 100, "Open-ear", true, 40, "USB");
            Wireless podpro = new Wireless ("Apple Airpod pro", 5, "In-Ear", true, 1000000, 300 ,"bluetooth 5.0");
            Noisecancelling quietcomfort = new Noisecancelling ("BOSE QuietComfort", 5, "In-Ear", true, 210, 300, "bluetooth 5.0", 3, "ANC");

            // Create another Wired headphone
            // Create a Wirelss headphone
            // Create a NoiseCancelling headphone

            // print the plugtype of the second wired headphone
            // print the WirelessProtocol of the wireless headphone
            // print he algorithm of the NoiseCancelling headphone

            System.Console.WriteLine(mx50.Name);
            System.Console.WriteLine(mx50.Cable.Material);
            System.Console.WriteLine(copperCable.Material);
            Console.WriteLine($"{h340.Name} is a {h340.Type} headset that costs {h340.Price} dollars");
            Console.WriteLine($"The second wired headphone is {h340.Name} its plug is {h340.PlugType}, the wireless headphone's protocol is {podpro.WirelessProtocol} and the noise cancelling headphone's algorithim is {quietcomfort.Algorithm}");

        }
    }
}
