﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientProfile.aspx.cs" Inherits="WebApplication3.clientProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr><td width="30%"><asp:Image ID="ImageID" runat="server" Height="100px" Width="100%" /></td>
                <td><asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label></td>
                <td><asp:Table runat="server"><asp:TableHeaderRow><asp:TableHeaderCell id="gender" Text="♀ ♂"/></asp:TableHeaderRow>
                    <asp:TableFooterRow><asp:TableCell id="birthdate" Text="Birthdate"/></asp:TableFooterRow></asp:Table></td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#99FFCC" BorderStyle="None" OnClick="Button1_Click" Text="Change your Profile" />
                </td></tr>
            <tr><td><asp:Label ID="username" runat="server" Text="Username" />
                <asp:Label ID="email" runat="server" Text="Email" /></td><td></td>
            <td><asp:HyperLink ID="pagelink" runat="server" Text="Find me elsewhere" NavigateUrl="."></asp:HyperLink></td></tr>
            <tr><td><asp:Label ID="description" runat="server" Text="Description" /></td></tr>
        </table>
    </form>
</body>
</html>
