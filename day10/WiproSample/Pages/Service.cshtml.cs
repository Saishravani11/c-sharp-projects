using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiproSample.Model;

namespace WiproSample.Pages
{
    public class ServiceModel : PageModel
    {
        public List<WiproData> Services { get; set; }

        public void OnGet()
        {
            List<WiproData> ser = new List<WiproData>();

            WiproData service1 = new WiproData("Gaming as a service", "abc", "123");
            WiproData service2 = new WiproData("Marketing as a service", "xyz", "456");
            WiproData service3 = new WiproData("product localization", "lmn", "789");

            ser.Add(service1);
            ser.Add(service2);
            ser.Add(service3);



            Services = ser;
        }
    }
}
