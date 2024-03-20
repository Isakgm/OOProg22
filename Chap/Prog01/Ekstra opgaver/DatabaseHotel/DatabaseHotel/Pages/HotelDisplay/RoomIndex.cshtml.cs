using DatabaseHotel.Model;
using DatabaseHotel.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DatabaseHotel.Pages.HotelDisplay
{
    public class RoomIndexModel : PageModel
    {
        public IHotelDatabase _repo;

        public RoomIndexModel(IHotelDatabase repo)
        {
            _repo = repo;
        }

        public double averagepPrice { get; set; }
        /*
         * properties til view
         */
        public List<Room> Rooms { get; set; }





        public void OnGet()
        {
            Rooms = _repo.GetAllRooms();
            if (Rooms.Any())
            {
                averagepPrice = (double)Rooms.Average(room => room.Price);
            }

        }
    }
}

