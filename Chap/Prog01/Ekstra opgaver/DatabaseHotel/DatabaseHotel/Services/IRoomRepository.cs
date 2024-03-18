using DatabaseHotel.Model;

namespace DatabaseHotel.Services
{
    public interface IRoomRepository
    {
        List<Room> GetAll();

        //Room AvgCost();
    }
}
