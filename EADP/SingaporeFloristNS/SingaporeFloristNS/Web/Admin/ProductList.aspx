<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="FreshFlowers.Web.Admin.ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product - Admin</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form runat="server">
       <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="#">Admin</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">                
                <li class="nav-item active">
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
        <h1 style="margin-top: 3%; margin-left: 15%;">View of All Products</h1>
        <div style="margin-top: 2%; margin-left: 15%;">

            <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" DataKeyNames="productID" Height="213px" Width="759px" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="productID" HeaderText="Product ID" />
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="unitPrice" DataFormatString="{0:C}" HeaderText="Unit Price" />
                    <asp:BoundField DataField="stock" HeaderText="Stock" />
                    <asp:ImageField DataImageUrlField="image" DataImageUrlFormatString="~/Web/Admin/ProductImages{0}.jpg" HeaderText="Image">
                    </asp:ImageField>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>

            <br />
          <%--  <asp:Button ID="btnNewProd" CssClass="btn btn-primary" runat="server" Text="Insert New Product" OnClick="btnNewProd_OnClick" />--%>

        </div>
    </form>
</body>
</html>
