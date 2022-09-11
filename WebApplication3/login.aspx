<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication3.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
    <style>
        table {
            width: 80%
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
            <table>
                <tr>
                    <td style="background-color:lightseagreen;">
                        <h3 style="text-align:center">
                            Log in form
                        </h3>
                    </td>
                    <td style="background-color:lightseagreen"></td>
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
            </fieldset>
        </div>
        <!--<iframe id="testframe" src="indexing.aspx" height="100%" width="80%"></iframe>-->
    </form>
</body>
</html>
