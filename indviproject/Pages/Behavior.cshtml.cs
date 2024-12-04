using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace indviproject.Pages
{
    [BindProperties]
    public class BehaviorModel : PageModel
    {
        public string CurrentStep { get; set; } = "Step1";

        public string BehaviorResponse { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            switch (CurrentStep)
            {
                case "Step1":
                    TempData["CompletedMessage"] = "Thank you for completing the form!";
                    return RedirectToPage("./ThankYou");



            }
            return Page();
        }
       
    }
}
