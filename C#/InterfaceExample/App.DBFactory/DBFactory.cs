using System;
using App.DBHelper.Interface;
using System.Configuration;

namespace App.Factory
{
    public static class DBFactory
    {
        public static IDbHelper GetDBHelper()
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
            return dbObject;
        }
    }
}
