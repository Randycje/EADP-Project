<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPayment.aspx.cs" Inherits="SingaporeFloristNS.ViewPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin - View Payment</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        
        
        <center><h1>Enter Payment</h1></center>
        <center>
        <p>
            &nbsp;</p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Card Number : </td>
                    <td>
                        <asp:TextBox ID="tbbankNumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Expiry Date :</td>
                    <td>
                        <asp:TextBox ID="tbExpiry" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">CVC : </td>
                    <td>
                        <asp:TextBox ID="tbCVC" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Payment Amount :</td>
                    <td>
                        <asp:Label ID="lblAmount" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Invoice ID : </td>
                    <td>
                        <asp:Label ID="lblInvoiceID" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" Text="Submit Payment" />
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
</body>
</html>
