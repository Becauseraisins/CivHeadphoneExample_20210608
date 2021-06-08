namespace CivHeadphoneExample_20210608.models
{
    public class Wired : Headphone
    {
        public string PlugType { get; set; }
        public Cable Cable { get; set; }

        public Wired(string name, uint weight, string type, bool microphone, 
        uint price, string plugType, Cable cable) : base(name, weight, type, microphone, price) {

            this.PlugType = plugType;
            this.Cable = cable;
        }
          public Wired(string name, uint weight, string type, bool microphone, 
        uint price, string plugType) : base(name, weight, type, microphone, price) {

            this.PlugType = plugType;
        }

    }
}