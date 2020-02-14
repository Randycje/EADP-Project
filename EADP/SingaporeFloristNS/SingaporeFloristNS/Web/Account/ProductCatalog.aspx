<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductCatalog.aspx.cs" Inherits="FreshFlowers.Web.Account.ProductCatalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Catalog!</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link href="bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <a class="navbar-brand" href="#">Account</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a class="nav-link" href="/Web/Account/Dashboard.aspx">Home <span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item active">
                            <a class="nav-link" href="/Web/Account/ProductCatalog.aspx">Product Catalog</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Your Orders</a>
                        </li>
                    </ul>
                    <asp:Label ID="lblUser" runat="server"  style="float:right; margin-left:auto;"></asp:Label>
                    <asp:Button ID="btnLogout" class="btn btn-danger" runat="server" Text="Logout" onClick="btnLogout_OnClick" style="float:left; margin-left:auto;"/>
                </div>
            </nav>
    </div>

        <div>
            <h1 style="margin-top:3%; margin-left:15%;">Product Catalog!</h1>
        <div style="margin-top:2%; margin-left:15%;">

            <asp:GridView ID="gvProduct" runat="server" UseAccessibleHeader="true" AutoGenerateColumns="False" DataKeyNames="productID" Height="213px" Width="759px" class="table table-striped table-hover">
                <Columns>
                    <asp:BoundField DataField="productID" HeaderText="Product ID" />
                    <asp:BoundField DataField="name" HeaderText="Name"  />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="unitPrice" DataFormatString="${0:n}" HeaderText="Unit Price" />
                    <asp:BoundField DataField="stock" HeaderText="Stock" />
                    <asp:ImageField DataImageUrlField="image" DataImageUrlFormatString="~\Web\Admin\ProductImages\{0}.jpg" alternatetext="Product Photo" HeaderText="Image">
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        </div>
        </div>
    </form>
</body>
</html>
