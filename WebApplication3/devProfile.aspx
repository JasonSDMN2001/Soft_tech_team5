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
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style3 {
            height: 26px;
            width: 160px;
        }
    }
        .auto-style3 {
            width: 167px;
        }
        .auto-style4 {
            width: 613px;
            height: 173px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style4">
            <tr><td class="auto-style2"><asp:Image ID="ImageID" runat="server" Height="100px" Width="100%" /></td>
                <td>
                    <asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label>
                </td>
                <td>
                    <asp:Table runat="server"><asp:TableHeaderRow><asp:TableHeaderCell id="gender" Text="♀ ♂"/></asp:TableHeaderRow>
                    <asp:TableFooterRow><asp:TableCell id="birthdate" Text="Birthdate"/></asp:TableFooterRow></asp:Table></td>
                <td class="auto-style3"><asp:Button ID="Button1" runat="server" BackColor="#99FFCC" BorderStyle="None" OnClick="Button1_Click" Text="Change your Profile" /></td></tr>
                <tr><td width="30%"><asp:Label ID="username" runat="server" Text="Username" />
                    </td>
                <td class="auto-style2">
        
                <asp:Label ID="email" runat="server" Text="Email" />
        
                    </td>
                <td>&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>
                &nbsp;</td></tr>
            <tr><td class="auto-style2"><asp:Label ID="Skills" runat="server" Text="Skills" /></td><td><asp:HyperLink ID="pagelink" runat="server" Text="Find me elsewhere" NavigateUrl="."></asp:HyperLink></td>
            <td>
                    &nbsp;</td></tr>
            <tr><td class="auto-style1"><asp:Label ID="description" runat="server" Text="Description" />
                </td><td>
                    &nbsp;</td></tr>
            <tr><td class="auto-style1"><asp:Label ID="bio" runat="server" Text="Bio" /></td><td class="auto-style3">
                <asp:Label ID="bio1" runat="server" Text="" />
                </td>
            <td class="auto-style1"></td></tr>
            <tr><td></td></tr>
            <tr><td>&nbsp;</td><td>
                </td></tr>
        </table>
          
        
        <iframe runat="server" id="devframe" width="100%"></iframe>
    </form>
</body>
</html>
