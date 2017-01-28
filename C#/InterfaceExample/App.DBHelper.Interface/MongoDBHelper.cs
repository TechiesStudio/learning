using System;

namespace App.DBHelper.Interface
{
    public class MongoDBHelper: IDbHelper
    {
        public void Connect_Database()
        {
            Console.WriteLine("MongoDB Database connected");
        }
        public void Disconnect_Database()
        {
            Console.WriteLine("MongoDB Database disconnected");
        }
        public string Execute_Query(string query)
        {
            Console.WriteLine("Query '" + query + "' executed in MongoDB Database");
            return query;
        }

    }
}
