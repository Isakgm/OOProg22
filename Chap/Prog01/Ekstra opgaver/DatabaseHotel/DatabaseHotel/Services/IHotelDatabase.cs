using DatabaseHotel.Model;

namespace DatabaseHotel.Services
{
    public interface IHotelDatabase
    {
        List<Hotel> GetAll(); 
    }
}
