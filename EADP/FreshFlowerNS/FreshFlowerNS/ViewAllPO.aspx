<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllPO.aspx.cs" Inherits="SingaporeFlorist.ViewAllPO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
        <h1>All Purchase Order</h1>
        <p>
            <asp:GridView ID="gv_PO" runat="server" AutoGenerateColumns="False" DataKeyNames="purcOrderID" CssClass="mt-5" OnSelectedIndexChanged="gv_PO_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="PO ID" DataField="purcOrderID" />
                    <asp:BoundField HeaderText="Description" DataField="purcOrderDesc" />
                    <asp:BoundField HeaderText="Product ID" DataField="purcOrderQuantity" />
                    <asp:BoundField HeaderText="Product Price" DataField="purcOrderPrice" DataFormatString="{0:C}" />
                    <asp:BoundField HeaderText="Date" DataField="purcOrderDate" />
                    <asp:CommandField ShowSelectButton="True" SelectText="Create CO" />
                </Columns>
            </asp:GridView>

            
        </p>
    </center>
        </div>
        <center>
        <p>
            <asp:Button ID="btn_back" runat="server" Text="Back To Product List" OnClick="btn_back_Click" CssClass="btn btn-info"/>
            &nbsp;
            <asp:Button ID="btn_CO" runat="server" Text="View Customer Orders" OnClick="btn_Co_Click" CssClass="btn btn-success"/>
        </p>
            </center>
    </form>
</body>
</html>
