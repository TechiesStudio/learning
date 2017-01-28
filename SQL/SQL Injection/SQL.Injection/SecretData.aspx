<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecretData.aspx.cs" Inherits="SQL.Injection.SecretData" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title>Secret Page</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <p></p>
            <label id="lbluserName" runat="server"></label>
            <p class="bg-primary">
                This is a simple Secret Page which will be only seen to Authenticated users only. If you have not logged in then you should not see this page.
    This is achieved by chceking whether session named "User" is present or not while on page load.
            </p>
        </div>
    </form>
</body>
</html>
