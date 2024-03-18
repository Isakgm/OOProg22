using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RunLib.Model;
using RunningRazorApp.Pages.Services;

namespace RunningRazorApp.Pages.Logins
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public String UserName { get; set; }

        [BindProperty]
        public String Pass { get; set; }

        [BindProperty]
        public String Fullname { get; set; }

        [BindProperty]
        public bool Role { get; set; }

        [BindProperty]
        public String ErrorMsg { get; set; }


        public void OnGet()
        {
            ErrorMsg = string.Empty;
        }

        public IActionResult OnPost()
        {
            if (UserName is null || Pass is null)
            {
                ErrorMsg = "Du skal skrive navn og Kodeord";
                return Page();
            }

            if (UserName != "JohnDoe" || Pass != "1234")
            {
                ErrorMsg = "Username eller Kodeord er ikke korrekt";
                return Page();
            }

            User user = new User(UserName, Pass, Fullname, false);
            SessionHelper.Set(user, HttpContext);

            return RedirectToPage("/Members/Index");
        }
    }
}
