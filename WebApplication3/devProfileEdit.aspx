<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="devProfileEdit.aspx.cs" Inherits="WebApplication3.devProfileEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit your Profile</title>
    <style type="text/css">
        .auto-style1 {
            width: 546px;
            height: 526px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr><td><asp:Label runat="server" Text="Username:"/></td><td><asp:TextBox ID="username" runat="server" placeholder="Username" /></td></tr>
            <tr><td><asp:Label runat="server" Text="Email:"/></td><td><asp:TextBox ID="email" runat="server" placeholder="Email" /></td></tr>
            <tr><td><asp:Label runat="server" Text="First name:"/></td><td><asp:TextBox ID="firstname" runat="server" placeholder="First name:" /></td></tr>
            <tr><td><asp:Label runat="server" Text="Last name:"/></td><td><asp:TextBox ID="lastname" runat="server" placeholder="Last name:" /></td></tr>
            <tr><td><asp:Label runat="server" Text="Gender:"/></td><td><asp:TextBox id="gender" runat="server" placeholder="♀ ♂"/></td></tr>
            <tr><td><asp:Label runat="server" Text="Skills:"/></td><td><asp:TextBox id="skills" runat="server" placeholder="skills" Height="57px" Width="159px"/></td></tr>
            <tr><td width="40%"><asp:Image ID="ImageID" runat="server" Height="100px" Width="100%" /></td>
                <td>
                <asp:FileUpload ID="FileUpload2" runat="server" CssClass="auto-style4" />
                
                </td></tr>
            
            
            <tr><td><asp:Button runat="server" Text="Save changes" ID="savebtn" BackColor="#00CC00" OnClick="savebtn_Click" /></td>
                <td><asp:Button runat="server" Text="Cancel" ID="cancelbtn" BackColor="Red" OnClick="cancelbtn_Click" /></td></tr>
        </table>
        
    </form>
</body>
</html>
