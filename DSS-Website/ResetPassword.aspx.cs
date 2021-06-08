using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DSS_Website
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RequestPassword"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie RequestCookies = Request.Cookies["userInfo"];
            string tempPassword = "";
            string tempEmail = "";
            if(RequestCookies != null)
            {
                tempPassword = RequestCookies["tempPassword"].ToString();
                tempEmail = RequestCookies["email"].ToString();
                if(tempPassword.Equals(password.Value) && tempEmail.Equals(email.Value))
                {
                    Response.Redirect("ChangePassword.aspx");
                }
                else
                {
                    email.Value = "";
                    password.Value = "";
                    MessageToClient("Email or Password is incorrect...");
                }
            }
            else
            {
                MessageToClient("Could not verify user. Please try again...");
                Response.Redirect("ForgotPassword.aspx");
            }
        }
        private void MessageToClient(string message)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + message + "');</script>");
        }
    }
}