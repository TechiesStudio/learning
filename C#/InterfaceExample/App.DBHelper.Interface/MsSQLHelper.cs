using System;

namespace App.DBHelper.Interface
{
    public class MsSQLHelper: IDbHelper
    {
        public void Connect_Database()
        {
            Console.WriteLine("MSSQL Database connected");
        }
        public void Disconnect_Database()
        {
            Console.WriteLine("MSSQL Database disconnected");
        }
        public string Execute_Query(string query)
        {
            Console.WriteLine("Query '"+ query +"' executed in MSSQL Database");
            return query;
        }
    }
}
