﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profileEdit.aspx.cs" Inherits="WebApplication3.profileEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit your Profile</title>
    <style type="text/css">

        .auto-style4 {
            margin-left: 0px;
        }
        </style>
</head>
<body height="80%">
    <form id="profileEdit" runat="server">
        <table>
            <tr><td><asp:Label runat="server" Text="Username:"/></td><td><asp:TextBox ID="username" runat="server" placeholder="Username" /></td>
            </tr>
            <tr><td><asp:Label runat="server" Text="Email:"/></td><td><asp:TextBox ID="email" runat="server" placeholder="Email" /></td>
                <td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="emailcheck"/></td></tr>
            <tr><td><asp:Label runat="server" Text="First name:"/></td><td><asp:TextBox ID="firstname" runat="server" placeholder="First name:" /></td></tr>
            <tr><td><asp:Label runat="server" Text="Last name:"/></td><td><asp:TextBox ID="lastname" runat="server" placeholder="Last name:" /></td>
                <td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="fullnamecheck"/></td>
            </tr>
            <tr><td><asp:Label runat="server" Text="Gender:"/></td><td><asp:TextBox id="gender" runat="server" placeholder="♀ ♂"/></td>
                <td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="gendercheck"/></td>
            </tr>
            <tr><td><asp:Label runat="server" Text="Birth date:"/></td><td><asp:TextBox id="birthdate" runat="server" placeholder="Birthdate"/></td>
                <td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="birthdatecheck"/></td>
            </tr>
            <tr><td width="40%"><asp:Image ID="ImageID" runat="server" Height="100px" Width="100%" /></td>
                <td>
                <asp:FileUpload ID="FileUpload2" runat="server" CssClass="auto-style4" />
                
                </td></tr>
            <tr><td><asp:Label runat="server" Text="Link of your page:"/></td><td><asp:TextBox ID="pagelink" runat="server" placeholder="example.com" /></td>
                <td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="pagelinkcheck"/></td>
            </tr>
            <tr><td><asp:Label runat="server" Text="Your description:"/></td><td><asp:TextBox ID="description" runat="server" placeholder="Description" /></td></tr>
            <tr><td><asp:Button runat="server" Text="Save changes" ID="savebtn" BackColor="#00CC00" OnClick="savebtn_Click" /></td>
                <td><asp:Button runat="server" Text="Cancel" ID="cancelbtn" BackColor="Red" OnClick="cancelbtn_Click" /></td></tr>
        </table>
    </form>
</body>
</html>
