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
                <td><asp:Label ID="title" runat="server" Text="Title" Font-Bold="True" Font-Size="15pt"></asp:Label></td>
                <td><asp:Label runat="server" ID="complete" Visible="False" Text="Finished" BackColor="#FFCC66"/></td>
            </tr>
            <tr><td><asp:Button runat="server" Text="Recommend to a developer" BackColor="#66FFCC" Width="100%" /></td></tr>
            <tr>
                <td><asp:Table runat="server"><asp:TableFooterRow><asp:TableCell id="category" Text="Category"/></asp:TableFooterRow>
                    <asp:TableFooterRow><asp:TableCell id="subcategory" Text="Subcategory"/></asp:TableFooterRow></asp:Table></td>
                <td><asp:Label runat="server" ID="rec_tech" Text="Doesn't exist"/></td>
                <td><asp:Label runat="server" ID="client_username" Text="Submitted by:"/></td>
            </tr>
            <tr><td><asp:Label ID="max_price" runat="server" Text="Price" /></td>
                <td><asp:Label ID="payment_method" runat="server" Text="Payment method" /></td>
            <td><asp:Label ID="interval" runat="server" Text="" /></td></tr>
            <tr><td><asp:Button runat="server" ID="offerbtn" Text="Make an offer" BackColor="#66FFCC" Width="100%" Visible="false" OnClick="offerbtn_Click" /></td></tr>
        </table>
        <asp:Label runat="server" ID="description"/>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Developers offer:" Visible="False"></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </form>
</body>
</html>
