<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign_Up.aspx.cs" Inherits="FreshFlowers.Web.Sign_Up" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SingaporeFlorist.sg - Sign Up</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>

    <style>
        .register-form
        {
            margin-top: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="register-form">
        <center>
    
        <h1>Sign Up - SingaporeFlorist</h1>
        <p style="margin-top:5%;">
            Name:
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        </p>
        <p>
            Email:
            <asp:TextBox ID="tbEmail" runat="server" TextMode="Email" MaxLength="50" ></asp:TextBox>
        </p>
        <p>
            Password:
            <asp:TextBox ID="tbPass" runat="server" TextMode="Password"></asp:TextBox>
        </p>
            <p>
            Confirm Password:
            <asp:TextBox ID="tbconPass" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
&nbsp;
            <asp:Button ID="btnRegister" class="btn btn-primary" runat="server" Text="Register" onClick="btnRegister_OnClick"/>
        </p>
        <p>
            Already have an account? Sign in <a href="Sign_In.aspx">here!</a></p></center>
    
    </div>
    </form>
</body>
</html>
