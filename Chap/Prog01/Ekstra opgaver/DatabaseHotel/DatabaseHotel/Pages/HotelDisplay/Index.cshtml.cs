using DatabaseHotel.Model;
using DatabaseHotel.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseHotel.Pages.HotelDisplay
{
    public class IndexModel : PageModel
    {
        private readonly IHotelDatabase _repo;

        public double AveragePrice { get; set; }

        public IndexModel(IHotelDatabase repo)
        {
            _repo = repo;
        }

        public List<Hotel> Hotels { get; set; }
        public void OnGet()
        {
            Hotels = _repo.GetAll();
        }
    }
}
