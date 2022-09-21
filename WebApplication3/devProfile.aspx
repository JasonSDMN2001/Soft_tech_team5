<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="devProfile.aspx.cs" Inherits="WebApplication3.devProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 355px;
        }
        .auto-style1 {
            height: 33px;
            width: 24%;
        }
        .auto-style2 {
            width: 24%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr><td class="auto-style2"><asp:Image ID="ImageID" runat="server" Height="100px" Width="100%" /></td>
                <td>
                    <asp:Label ID="gender" runat="server" Text="gender"></asp:Label>
                </td>
                <td>
                <asp:Button ID="Button1" runat="server" BackColor="#99FFCC" BorderStyle="None" OnClick="Button1_Click" Text="Change your Profile" />
                </td>
            <td>
                &nbsp;</td></tr>
            <tr><td class="auto-style2"><asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label></td><td><asp:Label ID="Skills" runat="server" Text="Skills" /></td>
            <td>
                    &nbsp;</td></tr>
            <tr><td class="auto-style1"><asp:Label ID="username" runat="server" Text="Username" />
                </td></tr>
        </table>
        
                <asp:Label ID="email" runat="server" Text="Email" />
        
    </form>
</body>
</html>
