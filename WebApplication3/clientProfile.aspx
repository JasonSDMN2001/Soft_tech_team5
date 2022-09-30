<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientProfile.aspx.cs" Inherits="WebApplication3.clientProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 333px;
        }
        .auto-style2 {
            height: 435px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style2">
        <asp:Table class="auto-style1" ID="TableNotifications" runat="server" Height="57px" BackColor="#DFFFFF">
            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Notifications: "/></asp:TableCell></asp:TableRow></asp:Table><br /><br /><table>
            <tr><td width="30%"><asp:Image ID="ImageID" runat="server" Height="100px" Width="100%" /></td>
                <td><asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label></td><td><asp:Table runat="server"><asp:TableHeaderRow><asp:TableHeaderCell id="gender" Text="♀ ♂"/></asp:TableHeaderRow>
                    <asp:TableFooterRow><asp:TableCell id="birthdate" Text="Birthdate"/></asp:TableFooterRow></asp:Table></td>
            <td>
                <asp:Button ID="Button1" runat="server" BackColor="#99FFCC" BorderStyle="None" OnClick="Button1_Click" Text="Change your Profile" />
                </td></tr>
            <tr><td><asp:Label ID="username" runat="server" Text="Username" />
                <asp:Label ID="email" runat="server" Text="Email" /></td><td></td>
            <td><asp:HyperLink ID="pagelink" runat="server" Text="Find me elsewhere" NavigateUrl="."></asp:HyperLink></td></tr><tr><td><asp:Label ID="description" runat="server" Text="Description" /></td></tr>
        </table>
        <asp:Table runat="server" BackColor="#99FFCC" ID="projectTable"><asp:TableRow><asp:TableHeaderCell>Submitted Projects:</asp:TableHeaderCell></asp:TableRow></asp:Table></form></body></html>