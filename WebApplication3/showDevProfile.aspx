<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showDevProfile.aspx.cs" Inherits="WebApplication3.showDevProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
        .auto-style1 {
            height: 465px;
        }
        .auto-style2 {
            height: 70px;
        }
        .auto-style4 {
            height: 70px;
            width: 22%;
        }
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
        }
        .auto-style12 {
            height: 935px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <table class="auto-style1">
            <tr><td class="auto-style10"><asp:Image ID="ImageID" runat="server" Height="119px" Width="100%" /></td><td></td>
            <td class="auto-style10"><asp:Label ID="fullname" runat="server" Text="Full name:"></asp:Label></td>
                <td class="auto-style4"> <asp:Label ID="fullname2" runat="server" Text="Full name"></asp:Label> </td>
            <td class="auto-style7"><asp:Label ID="username" runat="server" Text="Username:" /></td>
                <td class="auto-style8"><asp:Label ID="username2" runat="server" Text="Username:"  /></td>
                </tr>
            <tr>
            <td class="auto-style10"><asp:Label ID="Email" runat="server" Text="Email:" /></td>
                <td class="auto-style4"><asp:Label ID="Email2" runat="server" Text="Email:" /></td>
            
                <td class="auto-style10"><asp:Label ID="gend" runat="server" Text="Gender:" /></td>
                <td class="auto-style4"><asp:Label ID="gender2" runat="server" Text="Gender:" /></td>
            <td class="auto-style11"><asp:Label ID="Link1" runat="server" Text="Link:" /></td>
                               <td><label><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton></label></td></tr>

            </tr>
           <tr><td class="auto-style11"><asp:Label ID="skills" runat="server" Text="Skills:" /></td>
                <td class="auto-style9"><asp:Label ID="skills2" runat="server" Text="Skills:" /></td></tr>
           <tr><td class="auto-style11"><asp:Label ID="Label1" runat="server" Text="Rating:" />
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView></td>
                    <td><asp:Label ID="Label3" runat="server" Text="Finished Projects:" /><asp:GridView ID="GridView2" runat="server"></asp:GridView></td></tr>
               <tr><td class="auto-style11"><asp:Label ID="Label2" runat="server" Text="Bio:" /></td></tr>
        </table>
    </form>
    <iframe runat="server" id="pdfframe" width="100%" class="auto-style12"></iframe>
</body>
</html>
