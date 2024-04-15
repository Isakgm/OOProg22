using HotelApp.Model;

namespace HotelApp.Services
{
    public class HotelRepository : IHotelRepository
    {

        private HotelDBContext _db;
        public Hotel Add(Hotel hotel)
        {
            _db.Add(hotel);
            _db.SaveChanges();

            return hotel;
        }

        public void DeleteById(int id)
        {
            Hotel hotel = GetById(id);
            _db.Remove(hotel);
            _db.SaveChanges();
        }

        public List<Hotel> GetAll()
        {   
            return new List<Hotel>(_db.Hotels); ; // dette returnere en liste  
        }

        public Hotel GetById(int id)
        {
            Hotel? fundetHotel = _db.Hotels.FirstOrDefault(hotel => hotel.HotelNo == id);
            if (fundetHotel is null)
            {
                throw new KeyNotFoundException($"Hotel with id={id} is not found");
            }

            return fundetHotel;
        }

        public Hotel Update(int hotelNo, Hotel hotel)
        {
            if (hotelNo != hotel.HotelNo)
            {
                throw new ArgumentException($"Kan ikke updatere et id {hotelNo} med et andet {hotel.HotelNo}");
            }
            Hotel updateHotel = GetById(hotelNo);

            
            updateHotel.Name = hotel.Name;
            updateHotel.Address = hotel.Address;
            

            _db.SaveChanges();
            //int ix = _db.Hotels.IndexOf(updateHotel);
            //_members[ix] = Hotel;

            return hotel;
        }
    }
}
