<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profileEdit.aspx.cs" Inherits="WebApplication3.profileEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit your Profile</title>
</head>
<body>
    <form id="profileEdit" runat="server">
        <table>
            <tr><td><asp:TextBox ID="username" runat="server" Text="Username" /></td></tr>
            <tr><td><asp:TextBox ID="email" runat="server" Text="Email" /></td></tr>
            <tr><td><asp:TextBox ID="firstname" runat="server" Text="First name:" /></td></tr>
            <tr><td><asp:TextBox ID="lastname" runat="server" Text="Last name:" /></td></tr>
            <tr><td><asp:TextBox id="gender" runat="server" Text="♀ ♂"/></td></tr>
            <tr><td><asp:TextBox id="birthdate" runat="server" Text="Birthdate"/></td></tr>
            <tr><td width="40%"><asp:Image ID="ImageID" runat="server" Height="100px" Width="100%" /></td>
                <td><asp:Button runat="server" Text="Insert new Image" ID="imagebtn" /></td></tr>
            <tr><td><asp:TextBox ID="pagelink" runat="server" Text="example.com" /></td></tr>
            <tr><td><asp:TextBox ID="description" runat="server" Text="Description" /></td></tr>
            <tr><td><asp:Button runat="server" Text="Save changes" ID="savebtn" BackColor="#00CC00" /></td>
                <td><asp:Button runat="server" Text="Cancel" ID="cancelbtn" BackColor="Red" OnClick="cancelbtn_Click" /></td></tr>
        </table>
    </form>
</body>
</html>
