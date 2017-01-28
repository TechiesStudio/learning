using App.Factory;
using App.DBHelper.Interface;

namespace App.UI.Interface.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbHelper dbObject;
            dbObject = DBFactory.GetDBHelper();
            dbObject.Connect_Database();
            dbObject.Disconnect_Database();
            dbObject.Execute_Query("Its a sample query");
        }
    }
}
