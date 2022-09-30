<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminMainPage.aspx.cs" Inherits="WebApplication3.adminMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
    <style>
        .opt {
            background-color:white;
            display:block;
            margin:auto;
            Width:45%;
            font-weight: bold;
        }
        #clientframe {
            height: 371px;
            margin-bottom: 109px;
        }
        .auto-style1 {
            height: 458px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" style="background-color:lightgreen">
                <tr><td><asp:Button runat="server" Text="Delete a Client" ID="adminDeleteClient" class="opt" OnClick="adminDeleteClient_Click" /></td>
                <td><asp:Button runat="server" Text="Delete a Developer" ID="adminDeleteDev" class="opt" OnClick="adminDeleteDev_Click" /></td>
                <td><asp:Button runat="server" Text="Delete a Project" ID="adminDeleteProject" class="opt" OnClick="adminDeleteProject_Click" /></td></tr></table>
        <iframe runat="server" id="adminframe" width="100%" class="auto-style1"></iframe>
    </form>
</body>
</html>
