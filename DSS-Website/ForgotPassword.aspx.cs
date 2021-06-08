using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using DSS_Website.DSS_Service;

namespace DSS_Website
{
    
    public partial class ForgotPassword : System.Web.UI.Page
    {
        DSS_Service.DSSWebServiceClient service = new DSS_Service.DSSWebServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie userInfo = new HttpCookie("userInfo");
            string Password = RandomString();
            userInfo["tempPassword"] = Password;
            userInfo["email"] = email.Value;
            userInfo.Expires.Add(new TimeSpan(0, 1, 0));
            Response.Cookies.Add(userInfo);
            //Now send the email to the user
            if (email.Value != "" && service.VerifyUser(email.Value))
            {
                Session["RequestPassword"] = true;
                string subject = "Reset Password Request";
                string message = "Hey Customer \nPlease make use of this password within an hour \nPassword: " + Password;
              //  ClientMessage query = new ClientMessage("Customer", email.Value, subject, message);
                //query.sendToClient();
                Response.Redirect("ResetPassword.aspx");
            }
            else
            {
                email.Value = "";
                MessageToClient("Missing information in the text fields or You are not registered with us");
            }
        }
        private void MessageToClient(string message)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('" + message + "');</script>");
        }
        private string RandomString()
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            char temp;
            for (int i = 0; i < 10; i++)
            {
                temp = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                password.Append(temp);
            }
            return password.ToString();
        }
    }
}