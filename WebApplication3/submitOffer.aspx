<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submitOffer.aspx.cs" Inherits="WebApplication3.submitOffer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 219px;
        }
        .auto-style2 {
            margin-left: 230px;
        }
        .auto-style3 {
            margin-left: 355px;
        }
        .auto-style4 {
            margin-left: 235px;
        }
        .auto-style5 {
            margin-left: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Make an offer"></asp:Label>
        </div>
        <p>

            <asp:Label ID="Label4" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style4" Width="85px" ReadOnly="True"></asp:TextBox>
        </p>
        <p>

            <asp:Label ID="Label5" runat="server" Text="Project Title"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style1" Width="85px" ReadOnly="True"></asp:TextBox>
        </p>
        <p>

            <asp:Label ID="Label2" runat="server" Text="Fill the sum:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5" Width="85px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Comments:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Height="72px" Width="208px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Submit " />
        </p>
    </form>
</body>
</html>
