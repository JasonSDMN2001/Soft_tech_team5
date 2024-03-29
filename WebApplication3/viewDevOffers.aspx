﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewDevOffers.aspx.cs" Inherits="WebApplication3.viewDevOffers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Browse submitted offers"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Choose your desired category:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="auto-style2" Height="61px" Width="160px">
                <asp:ListItem>Active Projects</asp:ListItem>
                <asp:ListItem>Inactive Projects</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Height="199px" Width="409px">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
            <Columns>
                <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="title" DataNavigateUrlFormatString="editOffer.aspx?titlename={0}" />
                <asp:HyperLinkField Text="Cancel" DataNavigateUrlFields="title" DataNavigateUrlFormatString="deleteOffer.aspx?titlename={0}" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
