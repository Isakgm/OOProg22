using DatabaseHotel.Model;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Data.SqlClient;

namespace DatabaseHotel.Services
{
    public class HotelRepositoryDB : IHotelDatabase
    {
        public static string ConnectionString
        {
            get { return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"; }
        }

        private const String selectAllSql = "select * from Hotel";
        public List<Hotel> GetAll()
        {
            List<Hotel> hotels = new List<Hotel>();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(selectAllSql, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Hotel hotel = ReadHotel(reader);
                hotels.Add(hotel);
            }

            connection.Close();
            return hotels;
        }

        private Hotel ReadHotel(SqlDataReader reader)
        {
            Hotel hotel = new Hotel();

            hotel.Hotel_No = reader.GetInt32(0);
            hotel.Name = reader.GetString(1);
            hotel.Address = reader.GetString(2);

            return hotel;
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                string sql = "SELECT * FROM Room";
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Room room = ReadRoom(reader);
                    rooms.Add(room);
                }
            }

            return rooms;
        }

        private Room ReadRoom(SqlDataReader reader)
        {
            Room room = new Room();

            room.Room_No = reader.GetInt32(0);
            room.Hotel_No = reader.GetInt32(1);
            room.Price = reader.GetFloat(2);

            return room;
        }
    }
}
