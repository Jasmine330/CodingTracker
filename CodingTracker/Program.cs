using System;
using System.Configuration;

namespace CodingTracker
{
    public class Program
    {
        static string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public static void Main(string[] args)
        {
            DatabaseManager databaseManager = new();
            GetUserInput getUserInput = new();


            databaseManager.CreateTable(connectionString);
            getUserInput.MainMenu();
        }
    }
}