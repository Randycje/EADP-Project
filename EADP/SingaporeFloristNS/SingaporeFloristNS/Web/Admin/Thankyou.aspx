<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Thankyou.aspx.cs" Inherits="SingaporeFloristNS.Thankyou" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
            <h1>Payment Successful !</h1>
        <p>Thank You for shopping with FreshFlowers.</p>
        <p>
            <asp:Button ID="btnBack" runat="server" Text="Back To Homepage" OnClick="btnBack_Click" />
        </p>
    </div>
    </form>
</body>
</html>
