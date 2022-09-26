<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showProject.aspx.cs" Inherits="WebApplication3.showProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="title" runat="server" Text="Title"></asp:Label></td>
                <td><asp:Table runat="server"><asp:TableFooterRow><asp:TableCell id="category" Text="Category"/></asp:TableFooterRow>
                    <asp:TableFooterRow><asp:TableCell id="subcategory" Text="Subcategory"/></asp:TableFooterRow></asp:Table></td></tr>
            <tr><td><asp:Label ID="username" runat="server" Text="Username" />
                <asp:Label ID="email" runat="server" Text="Email" /></td>
            <td><asp:Label ID="description" runat="server" Text="Description" /></td></tr>
        </table>
    </form>
</body>
</html>
