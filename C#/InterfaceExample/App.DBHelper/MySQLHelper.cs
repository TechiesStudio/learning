using System;

namespace App.DBHelper
{
    public class MySQLHelper
    {
        public void Connect_Database()
        {
            Console.WriteLine("MySQL Database connected");
        }
        public void Disconnect_Database()
        {
            Console.WriteLine("MySQL Database disconnected");
        }
        public string Execute_Query(string query)
        {
            Console.WriteLine("Query '" + query + "' executed in MySQl Database");
            return query;
        }

    }
}
