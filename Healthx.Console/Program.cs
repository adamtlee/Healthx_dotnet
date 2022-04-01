using Npgsql;
using System;

namespace Healthx
{
    public  class Program
    {
        // build the connection string for the local db
        private static string Host = "localhost";
        private static string DBname = "DB_NAME";
        private static string UserName = "DB_USERNAME";
        private static string Password = "DB_PASSWORD";
        private static string Port = "5432";

        static void Main(string[] args)
        {
            string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    UserName,
                    DBname,
                    Port,
                    Password);

            using (var conn = new NpgsqlConnection(connString))

            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                Console.Out.WriteLine("Closing connection");
                conn.Close();
            }

            Console.WriteLine("Press RETURN to exit");
            Console.ReadLine();
        }
    }
}