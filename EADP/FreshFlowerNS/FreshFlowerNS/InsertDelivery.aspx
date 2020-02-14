<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertDelivery.aspx.cs" Inherits="FreshFlowerNS.InsertDelivery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
    
    <center><h1>Create Delivery</h1></center>
    <center>
    <table class="auto-style1">
        
            <tr>
                <td class="auto-style2">Order ID : </td>
                <td>
                    #<asp:Label ID="lblorderID" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Deliver to : </td>
                <td class="auto-style1">
                    <asp:Label ID="lblCompany" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Delivery Address : </td>
                <td>
                    <asp:Label ID="lblAddress" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Delivery Date : </td>
                <td>
                    <asp:TextBox ID="tbDate" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Delivery Status : </td>
                <td class="auto-style1">
                    <asp:Label ID="lblStatus" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Orders : </td>
                <td>
                    <asp:GridView ID="gvOrders" runat="server" DataKeyNames="corderDesc" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="corderDesc" HeaderText="Order Desc" />
                            <asp:BoundField DataField="corderPrice" DataFormatString="{0:C}" HeaderText="Order Price" />
                            <asp:BoundField DataField="corderQuantity" HeaderText="Order Quantity" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnCreate" runat="server" Text="Create Delivery" OnClick="btnCreate_Click"  />
                    <asp:Button ID="btnBack" runat="server" Text="Back to Customer Orders" OnClick="btn_co_Click"  />
                </td>
            </tr>
        </table>
    </center>
       </div>
    </form>
</body>
</html>
