﻿using System;

namespace App.DBHelper.Interface
{
    public class MySQLHelper: IDbHelper
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
            Console.WriteLine("Query '" + query + "' executed in MySQL Database");
            return query;
        }
    }
}
