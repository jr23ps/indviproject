using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace indviproject.Pages
{
    [BindProperties]
    public class contactModel : PageModel
    {
        public void OnGet()
        {
        }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        
        public string Reason { get; set; }

        public bool IsSubmitted { get; set; } = false;

        public void OnPost()
        {
            // Set flag to true after submission
            IsSubmitted = true;
        }
    }
}
