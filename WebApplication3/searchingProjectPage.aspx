<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchingProjectPage.aspx.cs" Inherits="WebApplication3.searchingProjectPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="searchform" runat="server">
        <h2>Search a Project</h2>
        <asp:TextBox runat="server" /><asp:Button runat="server" Text="Search"/>
        <br />
        <asp:Label runat="server" Text="Category:   "/>
        <asp:DropDownList runat="server" ID="category">
                    <asp:ListItem>Web Site</asp:ListItem><asp:ListItem>Database</asp:ListItem>
                    <asp:ListItem>Mobile app</asp:ListItem><asp:ListItem>Security</asp:ListItem></asp:DropDownList>
        <asp:Label runat="server" Text="Subcategory:   "/>
        <asp:DropDownList runat="server" ID="subcategory">
                    <asp:ListItem>Blog</asp:ListItem><asp:ListItem>Corporate</asp:ListItem>
                    <asp:ListItem>Ecommerce</asp:ListItem><asp:ListItem>Portal</asp:ListItem><asp:ListItem>Video Streaming</asp:ListItem>

        </asp:DropDownList>
            <asp:Table ID="TableID" runat="server">
            </asp:Table>
    </form>
</body>
</html>
