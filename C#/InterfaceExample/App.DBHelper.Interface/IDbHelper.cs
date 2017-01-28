namespace App.DBHelper.Interface
{
    public interface IDbHelper
    {
        void Connect_Database();
        void Disconnect_Database();
        string Execute_Query(string query);
    }
}
