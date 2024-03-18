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
    }
}
