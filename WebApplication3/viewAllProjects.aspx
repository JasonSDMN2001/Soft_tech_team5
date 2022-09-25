<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAllProjects.aspx.cs" Inherits="WebApplication3.viewAllProjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Browse All Projects</h2>
        <asp:Label runat="server" Text="Category:   "/>
        <asp:DropDownList runat="server"  autopostback="true" onselectedindexchanged="category_SelectedIndexChanged" ID="category">
                    <asp:ListItem>Web Site</asp:ListItem><asp:ListItem>Database</asp:ListItem>
                    <asp:ListItem>Mobile app</asp:ListItem><asp:ListItem>Security</asp:ListItem></asp:DropDownList>
        <asp:Label runat="server" Text="Subcategory:   "/>
        <asp:DropDownList runat="server" ID="subcategory" OnSelectedIndexChanged="subcategory_SelectedIndexChanged">
                    <asp:ListItem>Blog</asp:ListItem><asp:ListItem>Corporate</asp:ListItem>
                    <asp:ListItem>Ecommerce</asp:ListItem><asp:ListItem>Portal</asp:ListItem><asp:ListItem>Video Streaming</asp:ListItem>

        </asp:DropDownList>
            <asp:Table ID="TableID" runat="server">
            </asp:Table>
    </form>
</body>
</html>
