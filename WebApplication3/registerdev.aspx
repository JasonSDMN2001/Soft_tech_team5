<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerdev.aspx.cs" Inherits="WebApplication3.Registerdev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"href="style.css">
    <title>Register Developer</title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 96px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="registerdev" runat="server" style="background-color: slategray">
        <div style="height: 386px">
            <asp:ScriptManager ID="ScriptManager2" runat="server" EnablePageMethods="True">
            </asp:ScriptManager>
            <fieldset>
        <table>
            <tr><td style="background-color:orange; border:1px solid orange"><h3 style="text-align:center">
                Registration form</h3></td><td style="background-color:orange">as a developer</td></tr>

            <tr><td><asp:label runat="server" Text="Username" ID="label1"></asp:label></td>
                <td><asp:TextBox runat="server" ID="username1"
                    placeholder="State your username"></asp:TextBox></td></tr>

            <tr><td><asp:label runat="server" Text="Password" ID="label2"></asp:label></td>
                <td><asp:TextBox runat="server" ID="pass1" TextMode="Password"></asp:TextBox></td></tr>

            <tr><td><asp:label runat="server" Text="Confirm Password" ID="label3"></asp:label></td>
                <td><asp:TextBox runat="server" ID="passw2" TextMode="Password"></asp:TextBox></td></tr>
            
            <tr><td><asp:label runat="server" Text="E-mail" ID="label4"></asp:label></td>
                <td><asp:TextBox runat="server" ID="email1"
                    placeholder="E-mail"></asp:TextBox></td></tr>

            <tr><td><asp:label runat="server" Text="Name" ID="label5"></asp:label></td>
                <td><asp:TextBox runat="server" ID="firstname1"
                    placeholder="Name"></asp:TextBox></td></tr>

            <tr><td class="auto-style1"><asp:label runat="server" Text="Surname" ID="label6"></asp:label></td>
                <td class="auto-style1"><asp:TextBox runat="server" ID="lastname1"
                    placeholder="Surname"></asp:TextBox></td></tr>
            <tr><td class="auto-style1">Gender</td><td style="text-align:left" class="auto-style1"><asp:TextBox runat="server" ID="gender"
                    placeholder="Gender ♀ ♂"></asp:TextBox></td></tr>
            <tr><td class="auto-style3">Profile Image</td><td class="auto-style3">
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style4" />
                
              <asp:Button ID="Button2" runat="server" Text="Upload File" OnClick="UploadFile" /><br/>
            <asp:Image ID="image" runat="server" Height="92px" Width="176px"  /></td></tr>


            <tr><td class="auto-style2">
                <br />
                </td><td class="auto-style2"><input type="checkbox" name="term" id="term">
                <label>I agree with the user terms</label></td></tr>


            <tr><td>&nbsp;</td><td><asp:Button runat="server" style="background-color:red;color:white;" Text="Cancel" ID="Button1" OnClick="cancelBack" />
                <asp:Button style="background-color:green;color:white;" id="makeDev" runat="server" Text="Confirm" OnClick="makeDev_Click" /></td></tr>

        </table>
    </fieldset><br><br>
        </div>
    </form>
    
</body>
</html>
