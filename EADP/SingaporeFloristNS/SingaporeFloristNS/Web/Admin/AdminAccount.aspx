<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAccount.aspx.cs" Inherits="FreshFlowers.Web.Admin.AdminAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account - Admin</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="#">Admin</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">                
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/ProductList.aspx">Stocks</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/SupplierOrder.aspx">Orders</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/POrdersList.aspx">P Orders</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/Delivery.aspx">Delivery</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="/Web/Admin/AdminAccount.aspx">Users</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/ViewInvoice.aspx">Invoice</a>
                </li>
              </ul>
                <asp:Label ID="lblUser" runat="server"  style="float:left; margin-left:auto;"></asp:Label>
                <asp:Button ID="btnLogout" class="btn btn-danger" runat="server" Text="Logout" onClick="btnLogout_OnClick" style="float:left; margin-left:auto;"/>
            </div>
        </nav>
    </div>

        <p>&nbsp;</p>
        <h1 style="margin-top:3%; margin-left:15%;">View on All Existing Accounts</h1>
        <asp:GridView ID="gvUser" runat="server"
            AutoGenerateColumns="False" 
            Width="800px" 
            OnSelectedIndexChanged="gvUser_SelectedIndexChanged" 
            DataKeyNames="User_ID" style="margin-top:3%; margin-left:15%;"> 
            <Columns>
                <asp:BoundField DataField="User_ID" HeaderText="User ID"/>
                <asp:BoundField DataField="Name" HeaderText="Name"/>
                <asp:BoundField DataField="Email" HeaderText="Email"/>
                <asp:BoundField DataField="Title" HeaderText="Title"/>
            </Columns>
        </asp:GridView>

        <br />

        <asp:Label ID="lblResult" runat="server" style="margin-top:5%; margin-left:15%;"></asp:Label>

    </form>
    </form>
</body>
</html>
