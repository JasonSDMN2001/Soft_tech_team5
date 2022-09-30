<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="offerNews.aspx.cs" Inherits="WebApplication3.offerNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form2" runat="server">
        <asp:Table class="auto-style1" ID="TableNotifications" runat="server" Height="72px" BackColor="#DFFFFF" Width="242px">
            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Notifications: "/></asp:TableCell></asp:TableRow></asp:Table><p>
            &nbsp;</p><p>
            &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Browse submitted offers"></asp:Label></p><p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p><asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Height="199px" Width="409px">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
            
        </asp:GridView>
    </form>

</body>
</html>
