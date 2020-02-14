<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="SingaporeFlorist.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
        
    </div>
    </form>
</body>
</html>
