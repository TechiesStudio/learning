using System;
using System.Configuration;
using App.DBHelper;

namespace App.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbPlatform = ConfigurationManager.AppSettings["DbPlatform"];
            Console.WriteLine(dbPlatform);
            dynamic dbObject;
            switch (dbPlatform)
            {
                case "MySQL":
                    dbObject = new MySQLHelper();
                    dbObject.Connect_Database();
                    dbObject.Disconnect_Database();
                    dbObject.Execute_Query("Its a sample query");
                    break;
                case "MsSQL":
                    dbObject = new MsSQLHelper();
                    dbObject.Connect_Database();
                    dbObject.Disconnect_Database();
                    dbObject.Execute_Query("Its a sample query");
                    break;
                case "MongoDB":
                    dbObject = new MongoDBHelper();
                    dbObject.Connect_Database();
                    dbObject.Disconnect_Database();
                    dbObject.Execute_Query("Its a sample query");
                    break;
                default:
                    Console.WriteLine("No Proper Database Management Platform configured in App.Config");
                    break;
            }
        }
    }
}
