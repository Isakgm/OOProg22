using Mammamia.model;
using Mammamia.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mammamia.Pages.Kunder
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
    }
}
