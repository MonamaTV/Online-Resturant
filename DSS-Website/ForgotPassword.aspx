<%@ Page Title="" Language="C#" MasterPageFile="~/RootLayout.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="DSS_Website.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Reset Password | DigitalSS
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" href="../css/login.css">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <div class="login-section">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12 login-bg">
                    <form runat="server" class="login-form m-auto">
                        <h2 id="loginTitle" runat="server">Reset Password</h2>
                        <p>Please enter the e-mail address for your account. A verification token will be sent to you.</p>
                        <div class="input-login">
                            <label for="username" id="lblUsername" runat="server">Username</label>
                            <input type="text" name="username" id="email" placeholder="Enter your email" runat="server">
                        </div>             
                        <div class="input-login">
                            <asp:Button ID="btnLogin" runat="server" Text="SUBMIT" OnClick="btnLogin_Click" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
     </div>
</asp:Content>
