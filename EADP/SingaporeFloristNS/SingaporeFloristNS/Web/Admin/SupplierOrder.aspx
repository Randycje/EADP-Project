<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierOrder.aspx.cs" Inherits="SingaporeFloristNS.Web.Admin.SupplierOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin - Supplier Order</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
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
                <li class="nav-item active">
                    <a class="nav-link" href="/Web/Admin/SupplierOrder.aspx">Orders</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/POrdersList.aspx">P Orders</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/Delivery.aspx">Delivery</a>
                </li>
                <li class="nav-item">
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

        <h1>FRESH FLOWER</h1>
        <p>
            Welcome Back,
            <asp:Label ID="lblAdmin" runat="server"></asp:Label>
        </p>
        <h2><strong>Orders</strong></h2>
        <p>
            <asp:GridView ID="gvOrder" runat="server" DataKeyNames="orderId">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
