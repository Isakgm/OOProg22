using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace DatabaseConnect
{
    public class DB_Drink
    {
        private const string ConnectionString =
        "Data Source = mssql16.unoeuro.com; User ID = isakgm_dk; Password=f2t9wHmFRDenbEA53ghp;Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False";

        public List<Drink> GetAll()
        {
            List<Drink> drinks = new List<Drink>();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string sql = "select * from Drink";
            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Drink drink = ReadDrink(reader);
                drinks.Add(drink);
            }

            connection.Close();
                return drinks;
        }

        private Drink ReadDrink(SqlDataReader reader)
        {
            Drink drink = new Drink();

            drink.Id = reader.GetInt32(0);
            drink.Name = reader.GetString(1);
            drink.Alk = reader.GetBoolean(2);

            return drink;
        }

        private const string insertsql = "insert into Drink values(@name, @alk)";

        public void Add(Drink drink)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string sql = "insert into Drink values(@id, @name, @alk)";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@name", drink.Name);
            cmd.Parameters.AddWithValue("@alk", drink.Alk);

            int row = cmd.ExecuteNonQuery();
            Console.WriteLine("rows affected" + row);
           

            connection.Close();
        }
    }
}
