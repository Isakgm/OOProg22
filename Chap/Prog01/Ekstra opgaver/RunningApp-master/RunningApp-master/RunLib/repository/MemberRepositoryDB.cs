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
            member.Price = Convert.ToDouble(reader.GetDecimal(4));

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

        private const String deleteByIdlSql = "delete from Member where Id = @Id";
        public Member Delete(int id)
        {
            Member member = GetById(id);

            SqlConnection connection = new SqlConnection(Secret.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(deleteByIdlSql, connection);
            cmd.Parameters.AddWithValue("@id", id);

            int rows = cmd.ExecuteNonQuery();

            if (rows == 0)
            {
                throw new ArgumentException("Kunne ikke slette member med id=" + id);
            }
            connection.Close();

            return member;
        }

        private const String selectByIdlSql = "select * from Member where Id = @Id";
        public Member GetById(int id)
        {
            SqlConnection connection = new SqlConnection(Secret.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(selectByIdlSql, connection);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            Member member = null;
            if (reader.Read())
            {
                member = ReadMember(reader);
            }
            else
            {
                // no row i.e. not found
                throw new KeyNotFoundException();
            }

            connection.Close();
            return member;

        }

        private const String updateSql = "update Member set Name=@name, Mobile=@mobile, Team=@team, Price=@price where Id=@id";
        public Member Update(int id, Member updatedMember)
        {
            if (id != updatedMember.Id)
            {
                throw new ArgumentException("Kan ikke opdatere id er forskellig fra id i updatedeMember");
            }

            SqlConnection connection = new SqlConnection(Secret.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(insertSql, connection);
            cmd.Parameters.AddWithValue("@name", updatedMember.Name);
            cmd.Parameters.AddWithValue("@mobile", updatedMember.Mobile);
            cmd.Parameters.AddWithValue("@Id", updatedMember.Id);
            cmd.Parameters.AddWithValue("@team", updatedMember.Team);
            cmd.Parameters.AddWithValue("@price", updatedMember.Price);

            int row = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows affected " + row);

            connection.Close();
            return updatedMember;
        }
    }
}
