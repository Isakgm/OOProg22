using HotelApp.Model;

namespace HotelApp.Services
{
    public interface IHotelRepository
    {
        public List<Hotel> GetAll();
        public Hotel GetById(int id);
        public Hotel Add(Hotel hotel);
        public Hotel Update(int id, Hotel hotel);
        void DeleteById(int id);
    }
}
