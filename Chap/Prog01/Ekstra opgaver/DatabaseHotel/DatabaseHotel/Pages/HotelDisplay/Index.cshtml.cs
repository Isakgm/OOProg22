using DatabaseHotel.Model;
using DatabaseHotel.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseHotel.Pages.HotelDisplay
{
    public class IndexModel : PageModel
    {
        private readonly IHotelDatabase _repo;
        private readonly IRoomRepository _roomRepo;

        public double AveragePrice { get; set; }

        public IndexModel(IHotelDatabase repo)
        {
            _repo = repo;
        }

        public IndexModel(IRoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public List<Hotel> Hotels { get; set; }
        public List<Room> Rooms { get; set; }
        public void OnGet()
        {
            Rooms = _roomRepo.GetAll();
            if (Rooms.Any())
            {
                AveragePrice = Rooms.Average(room => room.Price);
            }
            Hotels = _repo.GetAll();
        }
    }
}
