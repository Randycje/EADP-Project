<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductView.aspx.cs" Inherits="SingaporeFlorist.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center">
            <h1>FreshFlower's Stocks</h1>
        </div>

        <center><div class="mt-3">
        <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" DataKeyNames="productID" Height="213px" Width="759px">
                <Columns>
                    <asp:BoundField DataField="productID" HeaderText="Product ID" />
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="description" HeaderText="Description" />
                    <asp:BoundField DataField="unitPrice" HeaderText="Unit Price" DataFormatString="{0:C}"/>
                    <asp:BoundField DataField="stock" HeaderText="Stock" />
                    <asp:ImageField DataImageUrlField="image" DataImageUrlFormatString="~/Web/Admin/ProductImages{0}.jpg" HeaderText="Image">
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        
            <br />
            <asp:Button ID="btnNewProd" CssClass="btn btn-primary" runat="server" Text="Insert New Product" OnClick="btnNewProd_OnClick" />
        &nbsp;
        <asp:Button ID="btnPO" CssClass="btn btn-info" runat="server" Text="Check PO List" OnClick="btnPO_OnClick" />

    </div></center>
    </form>
</body>
</html>
