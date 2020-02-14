<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delivery.aspx.cs" Inherits="FreshFlowerNS.Delivery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h1>Delivery Order</h1></center>
            <center>
            <asp:GridView ID="gvDelivery" runat="server" AutoGenerateColumns="False" DataKeyNames="DeliveryID" OnSelectedIndexChanged="gvDelivery_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="DeliveryID" HeaderText="Delivery ID" />
                    <asp:BoundField DataField="corderID" HeaderText="Order ID" />
                    <asp:BoundField DataField="DeliveryDate" HeaderText="Delivery Date" />
                    <asp:BoundField DataField="DeliveryStatus" HeaderText="Delivery Status" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Company Name" />
                    <asp:BoundField DataField="CompanyAddress" HeaderText="Company Address" />
                    <asp:CommandField ShowSelectButton="True" HeaderText="Create Invoice" SelectText="Create Invoice" />
                </Columns>
            </asp:GridView>
                <br />
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back to Customer Order" />
            </center>
        </div>
    </form>
</body>
</html>
