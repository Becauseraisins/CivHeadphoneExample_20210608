namespace CivHeadphoneExample_20210608.models
{
    public class Noisecancelling : Wireless
    {

        public uint Modes { get; set; }
        public string Algorithm { get; set; }
        public Noisecancelling(string name, uint weight, string type, bool microphone, uint price, uint batteryruntime, string wirelessProtocol, uint modes, string algorithm) : base(name, weight, type, microphone, price, batteryruntime, wirelessProtocol)
        {
            this.Modes = modes;
            this.Algorithm = algorithm;
        }


    }
}