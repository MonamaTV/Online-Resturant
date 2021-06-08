using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DSS_Website.DSS_Service;

namespace DSS_Website
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        DSSWebServiceClient service = new DSSWebServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["RequestPassword"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (password.Value.Equals(password1.Value))
            {
                if (!password.Value.Equals("") && !password1.Value.Equals(""))
                {
                    if (service.ChangeUserPassword(email.Value, password.Value, password1.Value) > 0)
                    {
                        MessageToClient("Successfully updated profile...");
                        Session["RequestPassword"] = null;
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        MessageToClient("Could not update profile...");
                    }
                }
                else
                {
                    MessageToClient("Missing text fields...");
                }
            }
            else
            {
                MessageToClient("Passwords do not match...");
            }
        }
        private void MessageToClient(string message)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + message + "');</script>");
        }
    }
}