<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierOrder.aspx.cs" Inherits="FreshFlowerNS.SupplierOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Orders</h1>
        <asp:Label ID="lblSearch" runat="server" Text="Search : "></asp:Label>
        <asp:TextBox ID="tbSearch" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
        <br />
        <asp:Label ID="lblFilter" runat="server" Text="Filter : "></asp:Label>
        <asp:DropDownList ID="ddlFilter" runat="server">
        </asp:DropDownList>
        <asp:GridView ID="grdOrders" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grdOrders_SelectedIndexChanged" DataKeyNames="corderID">
            <Columns>
                <asp:BoundField DataField="corderID" HeaderText="Order ID" />
                <asp:BoundField DataField="corderDesc" HeaderText="Item" />
                <asp:BoundField DataField="CompanyName" HeaderText="Company" />
                <asp:BoundField DataField="corderDate" HeaderText="Order Date" />
                <asp:BoundField DataField="corderStatus" HeaderText="Order Status" />
                <asp:CommandField HeaderText="View" SelectText="View" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
