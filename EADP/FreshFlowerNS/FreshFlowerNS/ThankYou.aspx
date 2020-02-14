<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="FreshFlowerNS.ThankYou" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <h1>Your invoice has been sent!</h1>
        <p>
            Please wait as Company makes payment. In the meantime, view past payment history from company
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">here.</asp:LinkButton>
        </p>
    </form>
</body>
</html>
