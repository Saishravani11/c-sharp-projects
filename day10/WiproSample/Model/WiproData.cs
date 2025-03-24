namespace WiproSample.Model
{
    public class WiproData
    {
        public string Service { get; set; }
        public string Description { get; set; }
        public string Pricing { get; set; }



        public WiproData(string service, string description, string pricing)
        {
            Service = service;
            Description = description;
            Pricing = pricing;




        }
    }
}
