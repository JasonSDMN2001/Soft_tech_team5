﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchingDevProfilePage.aspx.cs" Inherits="WebApplication3.searchingDevProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Search a Developer:        "></asp:Label>
        <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Sort By Joined Date" />
        <asp:Panel ID="MotherPanel" runat="server" Height="248px">
            <asp:Table ID="TableShow" runat="server" Height="243px" Width="961px">
            </asp:Table>
        </asp:Panel>
    </form>
</body>
</html>