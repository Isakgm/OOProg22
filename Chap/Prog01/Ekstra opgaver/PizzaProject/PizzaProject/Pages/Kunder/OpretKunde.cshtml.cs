using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaProject.model;
using PizzaProject.services;

namespace PizzaProject.Pages.Kunder
{
    public class OpretKundeModel : PageModel
    {
        [BindProperty]
        public int NytKundenummer { get; set; }
        [BindProperty]
        public string NytKundenavn { get; set; }
        [BindProperty]
        public string NytKundetlf { get; set; }


        public void OnGet()
        {

        }

        public void OnPost()
        {
            Kunde nyKunde = new Kunde(NytKundenummer, NytKundenavn, NytKundetlf);

            Kunderepository repo = new Kunderepository(true);
            repo.Tilføj(nyKunde);


        }
    }

}
