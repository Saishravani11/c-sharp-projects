using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WiproSample.Pages
{
    public class About_usModel : PageModel
    {
        public string aboutus { get; set; }
        public void OnGet()
        {
            aboutus = "Wipro is a global leader in IT services and consulting."; 
        }
    }
}
