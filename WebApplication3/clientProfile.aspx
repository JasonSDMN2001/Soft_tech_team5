<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientProfile.aspx.cs" Inherits="WebApplication3.clientProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr><td><asp:Image ID="ImageID" runat="server" Height="100px" Width="100px" /></td>
                <td><asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label></td>
            </tr>
            <tr><td><asp:Label ID="username" runat="server" Text="Username"></asp:Label></td></tr>
            <tr><td><asp:Label ID="email" runat="server" Text="Email"></asp:Label></td></tr>
        </table>
    </form>
</body>
</html>
