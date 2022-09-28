<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="devViewAllProjects.aspx.cs" Inherits="WebApplication3.devViewAllProjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <h2>Browse All Projects</h2>
        <asp:Label runat="server" Text="Category:   " ID="Label1"/>
        <asp:DropDownList runat="server"  autopostback="true" onselectedindexchanged="category_SelectedIndexChanged" ID="category">
                    <asp:ListItem>Web Site</asp:ListItem><asp:ListItem>Database</asp:ListItem>
                    <asp:ListItem>Mobile app</asp:ListItem><asp:ListItem>Security</asp:ListItem></asp:DropDownList>
        <asp:Label runat="server" Text="Subcategory:   " ID="Label2"/>
        <asp:DropDownList runat="server" ID="subcategory" AutoPostBack="True" OnSelectedIndexChanged="subcategory_SelectedIndexChanged">
                    <asp:ListItem>Blog</asp:ListItem><asp:ListItem>Corporate</asp:ListItem>
                    <asp:ListItem>Ecommerce</asp:ListItem><asp:ListItem>Portal</asp:ListItem><asp:ListItem>Video Streaming</asp:ListItem>

        </asp:DropDownList>
            
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
            <Columns>
                <asp:HyperLinkField Text="Show" DataNavigateUrlFields="title" DataNavigateUrlFormatString="showProject.aspx?titlename={0}" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
