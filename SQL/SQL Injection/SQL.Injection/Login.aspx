<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SQL.Injection.Login" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8">
    <title>Login Page</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <section id="content">
            <form id="form1" runat="server">
                <div>
                    <h1>SQL Injection Demo Login Form</h1>
                    <div class="form-group">
                        <label for="txtUsername">User Name</label>
                        <asp:TextBox runat="server" ID="txtUsername" class="form-control"/>
                    </div>
                    <div class="form-group">
                        <label for="txtPassword">Password</label>
                        <asp:TextBox runat="server" ID="txtPassword" class="form-control"/>
                    </div>
                    <div>
                        <asp:Button runat="server" Text="Log in InSecure" ID="btnSumbmit" OnClick="btnSumbmit_Click" CssClass="bg-primary" />
                        <asp:Button runat="server" Text="Log in Secure" ID="btnSubmitSecure" OnClick="btnSubmitSecure_Click" CssClass="bg-primary" />
                        <asp:Button runat="server" Text="Log in Secure with SP" ID="btnSubmitSecureSP" OnClick="btnSubmitSecureSP_Click" CssClass="bg-primary" />
                    </div>
                    <div>
                        <asp:Label ID="lblMessage" runat="server" CssClass="bg-danger"></asp:Label>
                    </div>
                </div>
            </form>
        </section>
    </div>
</body>
</html>
