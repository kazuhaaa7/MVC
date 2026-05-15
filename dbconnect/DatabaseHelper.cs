using Npgsql;
namespace MVC.dbconnect
{
    public class DatabaseHelper
    {
        private static string connString = "Host=localhost;Port=5432;Database=windform;Username=postgres;Password=postgre7";

        public static NpgsqlConnection GetConnect()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
