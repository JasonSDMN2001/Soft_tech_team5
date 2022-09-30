<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="WebApplication3.adminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
                <tr>
                    <td style="background-color:limegreen;">
                        <h3 style="text-align:center">
                            Log in as an Admin
                        </h3>
                    </td>
                    <td style="background-color:limegreen"></td>
                </tr>

                <tr>
                    <td><label>Username</label></td>
                    <td>
                        <asp:TextBox runat="server" id="name1" placeholder="Enter your username"/>
                    </td>
                </tr>

                <tr>
                    <td>
                        <label>
                            Password
                        </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" placeholder="Enter your password" id="pwd" TextMode="Password" />
                    </td>
                </tr>

                <tr><td><asp:Button runat="server" class="editbtn" Text="Login" OnClick="Unnamed1_Click"/></td></tr>
            </table>
    </form>
</body>
</html>
