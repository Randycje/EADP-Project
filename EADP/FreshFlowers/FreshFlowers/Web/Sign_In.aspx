<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign_In.aspx.cs" Inherits="FreshFlowers.Web.Sign_In" %>

<!DOCTYPE html>

<h<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SingaporeFlorist.sg - Sign In</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <style>
        body{
            text-align: center;
            background-image: url("");
            background-repeat: no-repeat;
            background-size: cover;
            background-position:center;

        }
    </style>
</head>
<body>
    <%--</br>--%>
        </br>
        </br>
        </br>
    <h1>Welcome to SingaporeFlorist</h1>
    <p>
        Enter your Name:</p>
    <form id="form1" runat="server">

            <asp:TextBox ID="tb_Name" runat="server"></asp:TextBox>

    <div>
    
        <p>
    
        <br />
        Enter your Password:<br />

        <asp:TextBox ID="tb_Password" runat="server" TextMode="Password"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="btn_Login" runat="server" class="btn btn-success" OnClick="btn_Login_Click" Text="Login!" />
        <asp:Button ID="btn_Back" runat="server" class="btn btn-primary" OnClick="btn_Back_OnClick" Text="Back!" />
            <br />
            <br />
            Don&#39;t have an account? <a href="Sign_Up.aspx">Click Here</a>
        </p>
    
    </div>
    </form>
</body>
</html>
