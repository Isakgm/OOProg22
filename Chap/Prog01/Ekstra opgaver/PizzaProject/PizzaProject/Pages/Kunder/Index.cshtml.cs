using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaProject.model;
using PizzaProject.services;

namespace PizzaProject.Pages.Kunder
{
    public class IndexModel : PageModel
    {
       
              //property til View'et
        public List<Kunde> Kunder { get; set; }

        public void OnGet()
        {
            Kunderepository repo = new Kunderepository(true);

            Kunder = repo.HentAlleKunder();
        }

        public IActionResult OnPost()
        {
           return  RedirectToPage("OpretKunde");
        }
    
    }
}
