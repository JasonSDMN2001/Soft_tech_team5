<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication3.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"href="style.css">
    <title>Register</title>
    <style type="text/css">

        .auto-style3 {
            height: 96px;
            width: 191px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            height: 712px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style10 {
            width: 191px;
        }
        .auto-style12 {
            height: 26px;
            width: 191px;
        }
        .auto-style13 {
            height: 665px;
        }
        .auto-style14 {
            width: 191px;
            height: 29px;
        }
        .auto-style15 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="register" runat="server" style="background-color: slategray">
        <div class="auto-style5">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
            </asp:ScriptManager>
            <fieldset class="auto-style13">
        <table>
            <tr><td style="background-color:orange; border:1px solid orange" class="auto-style10"><h3 style="text-align:center">
                Registration form</h3></td><td style="background-color:orange">as a client</td></tr>

            <tr><td class="auto-style10"><asp:label runat="server" Text="Username"></asp:label>(*)</td>
                <td><asp:TextBox runat="server" ID="username"
                    placeholder="State your username"></asp:TextBox></td></tr>

            <tr><td class="auto-style10"><asp:label runat="server" Text="Password"></asp:label>(*)</td>
                <td><asp:TextBox runat="server" ID="pass" TextMode="Password" Height="25px"></asp:TextBox></td></tr>

            <tr><td class="auto-style14"><asp:label runat="server" Text="Confirm Password"></asp:label>(*)</td>
                <td class="auto-style15"><asp:TextBox runat="server" ID="pass2" TextMode="Password"></asp:TextBox></td></tr>
            
            <tr><td class="auto-style10"><asp:label runat="server" Text="E-mail"></asp:label>(*)</td>
                <td><asp:TextBox runat="server" ID="email"
                    placeholder="E-mail"></asp:TextBox></td></tr>

            <tr><td class="auto-style10"><asp:label runat="server" Text="Name"></asp:label></td>
                <td><asp:TextBox runat="server" ID="firstname"
                    placeholder="Name"></asp:TextBox></td></tr>

            <tr><td class="auto-style10"><asp:label runat="server" Text="Surname"></asp:label></td>
                <td><asp:TextBox runat="server" ID="lastname"
                    placeholder="Surname"></asp:TextBox></td></tr>

            <tr><td class="auto-style10">Gender</td><td style="text-align:left" class="auto-style1">
                <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
                <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Female" />
                </td></tr>

            <tr><td class="auto-style10"><asp:label runat="server" Text="Date of Birth"></asp:label></td>
                <td><asp:TextBox runat="server" ID="TextBox1"
                     textmode="Date"></asp:TextBox></td></tr>

            
            <tr><td class="auto-style3">Profile Image</td><td style="text-align:left">
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style4" />
                
                <br/>
                </td></tr>
            <tr><td class="auto-style10">Description</td><td><asp:TextBox runat="server" ID="desc"
                    placeholder="state something" Height="54px" Width="248px"></asp:TextBox></td></tr>
            <tr><td class="auto-style10">Link</td><td><asp:TextBox runat="server" ID="link"
                    placeholder="link" Width="97px"></asp:TextBox>
                <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
                </td></tr>



            <tr><td class="auto-style12"></td><td class="auto-style6"><input type="checkbox" name="term" id="term">
                <label>I agree with the user terms<asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
                </label></td></tr>


            <tr><td class="auto-style10">&nbsp;</td><td><asp:Button runat="server" style="background-color:red;color:white;" Text="Cancel" ID="back" OnClick="cancelBack" />
                <asp:Button style="background-color:green;color:white;" id="makeUser" runat="server" Text="Confirm" OnClick="makeUser_Click" /></td></tr>

        </table>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" Text="(*)All fields with an asterisk must be completed."></asp:Label>
    </fieldset><br><br>
        </div>
    </form>
</body>
</html>
 
