using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace SQL.Injection
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection SQL_Connection;
        string SQL_Command_String;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnSumbmit_Click(object sender, EventArgs e)
        {
            //Getting Connection String from Web.Config file
            var SQL_Connection_String = ConfigurationManager.ConnectionStrings["SQL_Connection_String"].ConnectionString;
            SQL_Connection = new SqlConnection(SQL_Connection_String);

            //Making SQL Query with inputs recieved from username & password textbox
            SQL_Command_String = "select * from Users where userName='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
            lblMessage.Text = SQL_Command_String;

            //Getting user details which matches with username & password. Correct credentials will return one record and wrong one should return nothing
            //Data is retrived in Data Table
            SqlCommand SQL_Command = new SqlCommand(SQL_Command_String, SQL_Connection);
            SqlDataAdapter SQL_DA = new SqlDataAdapter(SQL_Command);
            DataTable SQL_DT = new DataTable();
            SQL_Command.CommandType = CommandType.Text;
            SQL_DA.Fill(SQL_DT);

            //Closing Database Connection
            SQL_Connection.Close();
            if (SQL_DT.Rows.Count >= 1)
            {
                Session.Add("loggedUser", txtUsername.Text);
                Response.Redirect("SecretData.aspx");
            }
            else
            {
                lblMessage.Text = "Incorrect Usrename or password";
            }
        }
        protected void btnSubmitSecure_Click(object sender, EventArgs e)
        {
            //Getting Connection String from Web.Config file
            var SQL_Connection_String = ConfigurationManager.ConnectionStrings["SQL_Connection_String"].ConnectionString;
            SQL_Connection = new SqlConnection(SQL_Connection_String);

            //Making SQL Query with inputs recieved from username & password textbox
            SQL_Command_String = "select * from Users where userName=@userName and password=@password";
            lblMessage.Text = SQL_Command_String;

            //Getting user details which matches with username & password. Correct credentials will return one record and wrong one should return nothing
            //Data is retrived in Data Table
            SqlCommand SQL_Command = new SqlCommand(SQL_Command_String, SQL_Connection);
            SqlDataAdapter SQL_DA = new SqlDataAdapter(SQL_Command);
            DataTable SQL_DT = new DataTable();
            SQL_Command.CommandType = CommandType.Text;
            SQL_Command.Parameters.AddWithValue("userName", txtUsername.Text);
            SQL_Command.Parameters.AddWithValue("password", txtPassword.Text);
            SQL_DA.Fill(SQL_DT);

            //Closing Database Connection
            SQL_Connection.Close();
            if (SQL_DT.Rows.Count >= 1)
            {
                Session.Add("loggedUser", txtUsername.Text);
                Response.Redirect("SecretData.aspx");
            }
            else
            {
                lblMessage.Text = "Incorrect Usrename or password";
            }
        }
        protected void btnSubmitSecureSP_Click(object sender, EventArgs e)
        {
            //Getting Connection String from Web.Config file
            var SQL_Connection_String = ConfigurationManager.ConnectionStrings["SQL_Connection_String"].ConnectionString;
            SQL_Connection = new SqlConnection(SQL_Connection_String);

            //Making SQL Query with inputs recieved from username & password textbox
            SQL_Command_String = "sp_validate_user";
            lblMessage.Text = SQL_Command_String;

            //Getting user details which matches with username & password. Correct credentials will return one record and wrong one should return nothing
            //Data is retrived in Data Table
            SqlCommand SQL_Command = new SqlCommand(SQL_Command_String, SQL_Connection);
            SqlDataAdapter SQL_DA = new SqlDataAdapter(SQL_Command);
            DataTable SQL_DT = new DataTable();
            SQL_Command.CommandType = CommandType.StoredProcedure;
            SQL_Command.Parameters.AddWithValue("userName", txtUsername.Text);
            SQL_Command.Parameters.AddWithValue("password", txtPassword.Text);
            SQL_DA.Fill(SQL_DT);

            //Closing Database Connection
            SQL_Connection.Close();
            if (SQL_DT.Rows.Count >= 1)
            {
                Session.Add("loggedUser", txtUsername.Text);
                Response.Redirect("SecretData.aspx");
            }
            else
            {
                lblMessage.Text = "Incorrect Usrename or password";
            }
        }
    }
}