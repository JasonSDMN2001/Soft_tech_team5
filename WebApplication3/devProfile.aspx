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
=======
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style3 {
            height: 26px;
            width: 160px;
>>>>>>> 36f66eb73259a276003fa1cfde25aab95af40774
        }
    }
        .auto-style3 {
            width: 167px;
        }
        .auto-style4 {
            width: 613px;
            height: 173px;
=======
        .auto-style7 {
            height: 62px;
            width: 9%;
        }
        .auto-style8 {
            height: 62px;
        }
        .auto-style9 {
            height: 164px;
            width: 22%;
        }
        .auto-style10 {
            height: 70px;
            width: 9%;
        }
        .auto-style11 {
            height: 164px;
            width: 9%;
>>>>>>> 5f315e930b24f53343aa94339652de4d6947955f
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<<<<<<< HEAD
        <table class="auto-style4">
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
        
        <iframe runat="server" id="devframe" width="100%"></iframe>
=======
       <table class="auto-style1">
            <tr><td class="auto-style10"><asp:Image ID="ImageID" runat="server" Height="119px" Width="39%" /></td>
             
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" BackColor="#99FFCC" BorderStyle="None" OnClick="Button1_Click" Text="Change your Profile" />
                </td></tr>
            <tr><td class="auto-style10"><asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label></td>
                <td class="auto-style4"> <asp:Label ID="fullname2" runat="server" Text="Full name"></asp:Label> </td>
            </tr>
            <tr><td class="auto-style7"><asp:Label ID="username" runat="server" Text="Username:" /></td>
                <td class="auto-style8"><asp:Label ID="username2" runat="server" Text="Username:"  /></td></tr>
            
            <tr><td class="auto-style10"><asp:Label ID="Email" runat="server" Text="Email:" /></td>
                <td class="auto-style4"><asp:Label ID="Email2" runat="server" Text="Email:" /></td>
            </tr>
                <tr><td class="auto-style10"><asp:Label ID="gend" runat="server" Text="Gender:" /></td>
                <td class="auto-style4"><asp:Label ID="gender2" runat="server" Text="Gender:" /></td>
            </tr>
            <tr><td class="auto-style11"><asp:Label ID="skills" runat="server" Text="Skills:" /></td>
                <td class="auto-style9"><asp:Label ID="skills2" runat="server" Text="Skills:" /></td>
            </tr>
        </table> 
        
>>>>>>> 5f315e930b24f53343aa94339652de4d6947955f
    </form>
</body>
</html>
