using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RunLib.Model;
using RunningRazorApp.Pages.Services;

namespace RunningRazorApp.Pages.Logins
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            SessionHelper.Clear<User>(HttpContext);

           return RedirectToPage("/Index");
        }
    }
}
