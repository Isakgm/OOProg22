using DatabaseHotel.Model;
using Microsoft.Data.SqlClient;

namespace DatabaseHotel.Services
{
    public class RoomRepositoryDB : IRoomRepository
    {
        public static string ConnectionString
        {
            get { return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"; }
        }

        //private const String selectRoomSql = "select AVG(Price) from Room";
        //public Room AvgCost()
        //{
        //    List<Room> roomsAvg = new List<Room>();

        //    SqlConnection connection = new SqlConnection(ConnectionString);
        //    connection.Open();

        //    SqlCommand cmd = new SqlCommand(selectRoomSql, connection);

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Room room = ReadRoom(reader);
        //        roomsAvg.Add(room);
        //    }

        //    connection.Close();
        //    return roomsAvg;
        //}

        private const String selectAllSql = "select * from Room";
        public List<Room> GetAll()
        {
            List<Room> rooms = new List<Room>();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(selectAllSql, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Room room = ReadRoom(reader);
                rooms.Add(room);
            }

            connection.Close();
            return rooms;
        }

        private Room ReadRoom(SqlDataReader reader)
        {
            Room room = new Room();

            room.Room_No = reader.GetInt32(0);
            room.Hotel_No = reader.GetInt32(1);
            //room.Types = reader.GetString(2);
            room.Price = reader.GetFloat(2);

            return room;
        }
    }
}
