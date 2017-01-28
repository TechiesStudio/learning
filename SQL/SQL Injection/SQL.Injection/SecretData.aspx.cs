using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQL.Injection
{
    public partial class SecretData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedUser"] != null)
            {
                lbluserName.InnerText = "Welcome " + Session["loggedUser"].ToString() + "!!!";
            }
            else
            {
                Response.Redirect("Unauthorised.aspx");
            }

        }
    }
}