<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="FreshFlowers.Web.Admin.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Product - Admin </title>
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
                <li class="nav-item active">
                    <a class="nav-link" href="/Web/Admin/Dashboard.aspx">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/ProductList.aspx">Stocks <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Orders</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">P Orders</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Delivery</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/Web/Admin/AdminAccount.aspx">Users</a>
                </li>
              </ul>
                <asp:Label ID="lblUser" runat="server"  style="float:left; margin-left:auto;"></asp:Label>
                <asp:Button ID="btnLogout" class="btn btn-danger" runat="server" Text="Logout" onClick="btnLogout_OnClick" style=" margin-left:auto;"/>
            </div>
        </nav>        
    </div>

        <div style="margin-left:5%; margin-top:5%;">
            <h1>Insert New Product</h1>
        <p>
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        </p>
        <p>
            Description:&nbsp;&nbsp;
            <asp:TextBox ID="tbDescription" runat="server"></asp:TextBox>
        </p>
        <p>
            Unit Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbUnitPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            Stock:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbStocks" runat="server"></asp:TextBox>
        </p>
        <p>
            Image:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="imageUpload" runat="server" />
        </p>
        <p>
            <asp:Button ID="btnInsert" runat="server" class="btn btn-success" Text="Add New Product" OnClick="btnInsert_OnClick" />
        &nbsp;
            <asp:Button ID="btnBack" runat="server" class="btn btn-danger" Text="Back" OnClick="btnBack_OnClick" Width="103px" />
        </p>
        </div>
        
    </form>
</body>
</html>
