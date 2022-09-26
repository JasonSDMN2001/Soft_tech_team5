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
                <td><asp:Label ID="title" runat="server" Text="Title" Font-Bold="True" Font-Size="15pt"></asp:Label></td></tr>
            <tr><td><asp:Button runat="server" Text="Recommend to a developer" BackColor="#66FFCC" Width="200%" /></td></tr>
            <tr>
                <td><asp:Table runat="server"><asp:TableFooterRow><asp:TableCell id="category" Text="Category"/></asp:TableFooterRow>
                    <asp:TableFooterRow><asp:TableCell id="subcategory" Text="Subcategory"/></asp:TableFooterRow></asp:Table></td>
                <td><asp:Label runat="server" ID="rec_tech" Text="Doesn't exist"/></td>
                <td><asp:Label runat="server" ID="client_username" Text="Submitted by:"/></td>
            </tr>
            <tr><td><asp:Label ID="max_price" runat="server" Text="Price" /></td>
                <td><asp:Label ID="payment_method" runat="server" Text="Payment method" /></td>
            <td><asp:Label ID="interval" runat="server" Text="" /></td></tr>
            <tr><td><asp:Label runat="server" ID="description"/></td></tr>
        </table>
    </form>
</body>
</html>
