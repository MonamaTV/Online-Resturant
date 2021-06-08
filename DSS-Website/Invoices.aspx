<%@ Page Title="" Language="C#" MasterPageFile="~/ClientView.master" AutoEventWireup="true" CodeBehind="Invoices.aspx.cs" Inherits="DSS_Website.Invoices" %>
<asp:Content ID="Content1" ContentPlaceHolderID="data" runat="server">
        <div class="heads">
        <h2 class="text-center">Invoices</h2>
        <hr />
            <br />
            <form id="invoicesForm" runat="server">
                <asp:DropDownList ID="invoicesDrop" runat="server" class="btn btn-add sort invoices" OnSelectedIndexChanged="invoicesDrop_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Value="-1">Invoices</asp:ListItem>
                    <asp:ListItem Value="1">Today</asp:ListItem>
                    <asp:ListItem Value="2">Last 7 Days</asp:ListItem>
                    <asp:ListItem Value="3">Last 30 Days</asp:ListItem>
                    <asp:ListItem Value="4">Last 365 Days</asp:ListItem>
                </asp:DropDownList>      
           </form>                  
    </div>
    <br />
     <table class="our-table">
         <thead>
             <tr>
                 <th>Order ID</th>
                 <th>Client Name</th>
                 <th>Date</th>
                 <th>Payment Method</th>
                 <th>Delivery</th>
                 <th>Amount Due</th>
                 <th>Items Bought</th>
             </tr>
         </thead>
         <tbody>
             <div id="items" runat="server">

             </div>
         </tbody>
      </table>
</asp:Content>
