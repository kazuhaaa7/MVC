using MVC.Models;
using Npgsql;

namespace MVC.dbconnect
{
    public class DatabaseHelper
    {
        private string connString = "Host=localhost;Port=5432;Database=windform;Username=postgres;Password=postgre7";


        // READ - ambil semua user
        public List<m_User> GetAllUsers()
        {
            List<m_User> list = new List<m_User>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT id, nama, umur, asal FROM users", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new m_User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetString(3)
                ));
            }
            return list;
        }


        // CREATE
        public void AddUser(m_User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO users (nama, umur, asal) VALUES (@nama, @umur, @asal)", conn);
            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);
            cmd.ExecuteNonQuery();
        }


        // UPDATE
        public void UpdateUser(m_User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE users SET nama=@nama, umur=@umur, asal=@asal WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("id", user.id);
            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);
            cmd.ExecuteNonQuery();
        }


        // DELETE
        public void DeleteUser(int id)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM users WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
