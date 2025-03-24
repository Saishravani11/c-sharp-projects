using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WiproSample.Pages
{
    public class Contact_usModel : PageModel
    {
        public string Contactno { get; set; }
        
        public void OnGet()
        {
            Contactno = "23454456";
           
        }
    }
}
