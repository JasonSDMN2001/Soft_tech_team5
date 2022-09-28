<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchingProjectPage.aspx.cs" Inherits="WebApplication3.searchingProjectPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="searchform" runat="server">
        <h2>Search a Project</h2>
        <table>
            <tr><td><asp:Label runat="server" Text="Title: "/></td><td><asp:TextBox runat="server" id="title"/></td></tr>
            <tr><td><asp:Label runat="server" Text="Description: "/></td><td><asp:TextBox runat="server" id="description"/></td></tr>
            <tr><td><asp:Label runat="server" Text="Recommended Technology: "/></td><td><asp:TextBox runat="server" id="rec_tech"/></td></tr>
            <tr><td><asp:Button runat="server" Text="Search" ID="searchprojectbtn" OnClick="searchprojectbtn_Click"/></td><td><asp:CheckBox ID="CheckBox1" runat="server" Text="Sort By Oldest" /></td></tr>    
        </table>
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
