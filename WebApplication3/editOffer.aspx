﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editOffer.aspx.cs" Inherits="WebApplication3.editOffer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
            margin-left: 184px;
        }
        .auto-style2 {
            margin-left: 195px;
        }
        .auto-style3 {
            margin-left: 355px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Edit your offer"></asp:Label>
        </div>
        <p>

            <asp:Label ID="Label4" runat="server" Text="sum:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </p>
        <p>

            <asp:Label ID="Label5" runat="server" Text="Comments:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        </p>
        <p>

            <asp:Label ID="Label2" runat="server" Text="Fill the new sum:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5" Width="85px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="new Comments:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Height="72px" Width="208px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Edit" Width="68px" />
        </p>
    </form>
    
</body>
</html>
