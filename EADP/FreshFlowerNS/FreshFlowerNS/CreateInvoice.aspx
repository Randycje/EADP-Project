<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateInvoice.aspx.cs" Inherits="FreshFlowerNS.CreateInvoice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Invoice</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <style type="text/css">
        .auto-style1 {
            width: 1514px;
        }
        .auto-style2 {
            width: 1513px;
        }
        .auto-style4 {
            width: 564px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <center><h1>Create Invoice</h1></center>
           <center>
            <div>
                Dear
            <asp:Label ID="lblCompany" runat="server"></asp:Label>
                , we thank you for your support. Attached below pertains your order details :
             
            </div>
           </center>
           <center>
            <table class="w-100">
                <tr>
                    <td class="auto-style4">Delivery Address :
                    <asp:Label ID="lblBillAdd" runat="server"></asp:Label></td>
                    <td>Invoice Date :
                        <asp:TextBox ID="tbInvoiceDate" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>
                <tr>
                    <td >Delivery Date :
                        <asp:Label ID="lblDeliveryDate" runat="server"></asp:Label>
                    </td>
                    <<td >Delivery Status :
                        <asp:Label ID="lblStatus" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" rowspan="3">
                        <asp:GridView ID="grdOrders" runat="server" AutoGenerateColumns="False" OnRowDataBound="grdOrders_RowDataBound" DataKeyNames="corderID" >
                            <Columns>
                                <asp:BoundField DataField="corderID" HeaderText="ID" />
                                <asp:BoundField DataField="corderDesc" HeaderText="Order Description" />
                                <asp:BoundField DataField="corderPrice" DataFormatString="{0:C}" HeaderText="Price" />
                                <asp:BoundField DataField="corderQuantity" HeaderText="Quantity" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td class="auto-style1">Subtotal Price : $<asp:Label ID="lblSubtotalPrice" runat="server"></asp:Label>
                </td>
                </tr>
                <tr>
                    <td class="auto-style2">Delivery Fee : $<asp:TextBox ID="tbFee" runat="server"></asp:TextBox>
                </td>
                </tr>
                <tr>
                    <td >Total Price : $<asp:TextBox ID="tbTotalPrice" runat="server" ></asp:TextBox>
                </td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="btnSend" runat="server" Text="Send to Company" OnClick="btnSend_Click" cssclass="btn btn-success"/></td>
                    <td><asp:Button ID="btnback" runat="server" Text="Back to Invoice List" OnClick="btnInvoice_Click" cssclass="btn btn-success"/></td>
                </tr>
            </table>
            </center>
        </div>
        </form>
</body>
</html>
