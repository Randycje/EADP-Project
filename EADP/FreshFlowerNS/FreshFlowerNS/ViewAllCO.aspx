<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllCO.aspx.cs" Inherits="FreshFlowerNS.ViewAllCO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <center><h1>All Customer Orders</h1></center>
            <center>
                <asp:Label ID="lblSearch" runat="server" Text="Search : "></asp:Label>
                <asp:TextBox ID="tbSearch" runat="server"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            </center>
            <center>
            <asp:GridView ID="gv_CO" runat="server" AutoGenerateColumns="False" DataKeyNames="corderID" OnSelectedIndexChanged="gv_CO_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="corderID" HeaderText="CO ID" />
                    <asp:BoundField DataField="corderDesc" HeaderText="CO Description"/>
                    <asp:BoundField DataField="corderDate" HeaderText="Created Date"/>
                    <asp:BoundField DataField="corderPrice" HeaderText="CO Price"/>
                    <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                    <asp:CommandField HeaderText="Create DO" SelectText="Create DO" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
                <br />
            </center>
        <center><asp:Button ID="btn_PO" runat="server" Text="View PO" CssClass="btn btn-info" OnClick="btn_PO_Click" />
            <asp:Button ID="Button1" runat="server" Text="View Delivery Orders" CssClass="btn btn-success" OnClick="btn_delivery_Click" />
        </center>
    </form>
</body>
</html>
