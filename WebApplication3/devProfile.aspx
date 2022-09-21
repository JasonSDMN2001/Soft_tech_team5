<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="devProfile.aspx.cs" Inherits="WebApplication3.devProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 465px;
        }
        .auto-style2 {
            width: 24%;
=======
        .auto-style1 {
            height: 26px;
        }
        .auto-style4 {
            height: 70px;
            width: 22%;
        }
        .auto-style3 {
            height: 26px;
            width: 160px;
>>>>>>> 36f66eb73259a276003fa1cfde25aab95af40774
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
<<<<<<< HEAD
            <tr><td class="auto-style2"><asp:Image ID="ImageID" runat="server" Height="100px" Width="100%" /></td>
                <td>
                    <asp:Label ID="gender" runat="server" Text="gender"></asp:Label>
                </td>
                <td>
=======
            <tr><td width="30%"><asp:Image ID="ImageID" runat="server" Height="140px" Width="280px" /></td>
                <td class="auto-style2"><asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label></td>
                <td><asp:Table runat="server"><asp:TableHeaderRow><asp:TableHeaderCell id="gender" Text="♀ ♂"/></asp:TableHeaderRow>
                    <asp:TableFooterRow><asp:TableCell id="birthdate" Text="Birthdate"/></asp:TableFooterRow></asp:Table></td>
            <td>
>>>>>>> 36f66eb73259a276003fa1cfde25aab95af40774
                <asp:Button ID="Button1" runat="server" BackColor="#99FFCC" BorderStyle="None" OnClick="Button1_Click" Text="Change your Profile" />
                </td>
            <td>
                &nbsp;</td></tr>
            <tr><td class="auto-style2"><asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label></td><td><asp:Label ID="Skills" runat="server" Text="Skills" /></td>
            <td>
                    &nbsp;</td></tr>
            <tr><td class="auto-style1"><asp:Label ID="username" runat="server" Text="Username" />
                </td></tr>
<<<<<<< HEAD
        </table>
        
                <asp:Label ID="email" runat="server" Text="Email" />
        
=======
            <tr><td class="auto-style1"><asp:Label ID="username" runat="server" Text="Username" />
                <asp:Label ID="email" runat="server" Text="Email" /></td><td class="auto-style3"></td>
            <td class="auto-style1"><asp:HyperLink ID="pagelink" runat="server" Text="Find me elsewhere" NavigateUrl="."></asp:HyperLink></td></tr>
            <tr><td><asp:Label ID="description" runat="server" Text="Description" /></td></tr>
            <tr><td><asp:Label ID="bio" runat="server" Text="Bio" /></td><td>
                <asp:Label ID="bio1" runat="server" Text="" />
                </td></tr>
        </table>
        <iframe runat="server" id="devframe" width="100%"></iframe>
>>>>>>> 36f66eb73259a276003fa1cfde25aab95af40774
    </form>
</body>
</html>
