using App.DBHelper.Interface;
using System;
using System.Configuration;

namespace App.UI.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbPlatform = ConfigurationManager.AppSettings["DbPlatform"];
            Console.WriteLine(dbPlatform);
            IDbHelper dbObject;
            switch (dbPlatform)
            {
                case "MySQL":
                    dbObject = new MySQLHelper();
                    break;
                case "MsSQL":
                    dbObject = new MsSQLHelper();
                    break;
                case "MongoDB":
                    dbObject = new MongoDBHelper();
                    break;
                default:
                    Console.WriteLine("No Proper Database Management Platform configured in App.Config");
                    dbObject = new MySQLHelper();
                    break;
            }
            dbObject.Connect_Database();
            dbObject.Disconnect_Database();
            dbObject.Execute_Query("Its a sample query");

        }
    }
}
