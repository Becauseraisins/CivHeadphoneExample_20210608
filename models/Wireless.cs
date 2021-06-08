namespace CivHeadphoneExample_20210608.models
{
    public class Wireless : Headphone
    {

        //runtime is in minutes
        public uint Batteryruntime { get; set; }

        public string WirelessProtocol { get; set; }

        public Noisecancelling Noisecancelling { get; set; }

        public Wireless(string name, uint weight, string type, bool microphone, uint price,uint batteryruntime, string wirelessProtocol) : base(name, weight, type, microphone, price)
        {
            this.Batteryruntime = batteryruntime;
            this.WirelessProtocol = wirelessProtocol;
            
        }

                public Wireless(string name, uint weight, string type, bool microphone, uint price,uint batteryruntime, string wirelessProtocol, Noisecancelling noisecancelling) : base(name, weight, type, microphone, price)
        {
            this.Batteryruntime = batteryruntime;
            this.WirelessProtocol = wirelessProtocol;
            
        }
    }
}