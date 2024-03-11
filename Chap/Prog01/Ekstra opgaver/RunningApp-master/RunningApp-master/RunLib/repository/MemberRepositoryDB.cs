using Microsoft.Data.SqlClient;
using RunLib.model;
using Microsoft.Identity.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLib.repository
{
    public class MemberRepositoryDB : IMemberRepository
    {


        private const String selectAllSql = "select * from Member";
        public List<Member> GetAll()
        {
            List<Member> members = new List<Member>();

            SqlConnection connection = new SqlConnection(Secret.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(selectAllSql, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Member member = ReadMember(reader);
                members.Add(member);
            }

            connection.Close();
            return members;
        }

        private Member ReadMember(SqlDataReader reader)
        {
            Member member = new Member();

            member.Id = reader.GetInt32(0);
            member.Name = reader.GetString(1);
            member.Mobile = reader.GetString(2);
            member.Team = reader.GetString(3);
            member.Price = reader.GetDouble(4);

            return member;
        }

        private const String insertSql = "insert into Member values(@Name, @Mobile, @Team, @Price)";
        public Member Add(Member m)
        {
            SqlConnection connection = new SqlConnection(Secret.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(insertSql, connection);
            cmd.Parameters.AddWithValue("@Name", m.Name);
            cmd.Parameters.AddWithValue("@Mobile", m.Mobile);
            cmd.Parameters.AddWithValue("@Team", m.Team);
            cmd.Parameters.AddWithValue("@Price", m.Price);

            int rows = cmd.ExecuteNonQuery();
            if (rows == 0) 
            {
                throw new ArgumentException("Kunne ikke oprette member =" + m);
            }
            


            connection.Close();
            return m;
        }

        public Member Delete(int id)
        {
            // SQL query to delete member by ID and retrieve deleted member
            string query = "DELETE FROM Members OUTPUT DELETED.Id, DELETED.Name, DELETED.Mobile, DELETED.Team, DELETED.Price WHERE Id = @Id";

            // Create connection
            using (SqlConnection connection = new SqlConnection(Secret.ConnectionString))
            {
                // Open connection
                connection.Open();

                // Create command with parameters
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter
                    command.Parameters.AddWithValue("@Id", id);

                    // Execute the command and get the reader for retrieving the deleted member
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there is a result
                        if (reader.Read())
                        {
                            // Create and return the deleted member
                            return new Member(
                                Convert.ToInt32(reader["Id"]),
                                reader["Name"].ToString(),
                                reader["Mobile"].ToString(),
                                reader["Team"].ToString(),
                                Convert.ToInt32(reader["Price"])
                            );
                        }
                    }
                }
            }

            // Return null if no member was found and deleted
            return null;

        }

        public Member GetById(int id)
        {
            // Initialize member variable to null
            Member member = null;

            // SQL query to retrieve member by ID
            string query = "SELECT * FROM Members WHERE Id = @Id";

            // Create connection
            using (SqlConnection connection = new SqlConnection(Secret.ConnectionString))
            {
                // Open connection
                connection.Open();

                // Create command with parameters
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter
                    command.Parameters.AddWithValue("@Id", id);

                    // Execute reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there is a result
                        if (reader.Read())
                        {
                            // Create new Member object with data from the reader
                            member = new Member(
                                id,
                                reader["Name"].ToString(),
                                reader["Mobile"].ToString(),
                                reader["Team"].ToString(),
                                Convert.ToDouble(reader["Price"])
                            );
                        }
                    }
                }
            }
            
            // Return the member (which may be null if not found)
            return member;
        }

        public Member Update(int id, Member member)
        {
            // SQL query to update member by ID and retrieve updated member
            string query = "UPDATE Members SET Name = @Name, Mobile = @Moblie, Team = @Team, Price = @Price OUTPUT INSERTED.Id, INSERTED.Name, INSERTED.Mobile, INSERTED.Team, INSERTED.Price WHERE Id = @Id";

            // Create connection
            using (SqlConnection connection = new SqlConnection(Secret.ConnectionString))
            {
                // Open connection
                connection.Open();

                // Create command with parameters
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", member.Name);
                    command.Parameters.AddWithValue("@Mobile", member.Mobile);
                    command.Parameters.AddWithValue("@Team", member.Team);
                    command.Parameters.AddWithValue("@Price", member.Price);

                    // Execute the command and get the reader for retrieving the updated member
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there is a result
                        if (reader.Read())
                        {
                            // Create and return the updated member
                            return new Member(
                                Convert.ToInt32(reader["Id"]),
                                reader["Name"].ToString(),
                                reader["Mobile"].ToString(),
                                reader["Team"].ToString(),
                                Convert.ToDouble(reader["Price"])
                            );
                        }
                    }
                }
            }

            // Return null if no member was found and updated
            return null;
        }
    }
}
