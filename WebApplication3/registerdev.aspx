<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerdev.aspx.cs" Inherits="WebApplication3.Registerdev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"href="style.css">
    <title>Register Developer</title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
            width: 174px;
        }
        .auto-style2 {
            height: 26px;
            width: 174px;
        }
        .auto-style3 {
            height: 96px;
            width: 174px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            height: 978px;
        }
        .auto-style6 {
            height: 243px;
            width: 174px;
        }
        .auto-style7 {
            margin-top: 0px;
        }
        .auto-style8 {
            width: 292px;
        }
        .auto-style9 {
            height: 29px;
            width: 292px;
        }
        .auto-style10 {
            height: 96px;
            width: 292px;
        }
        .auto-style11 {
            height: 243px;
            width: 292px;
        }
        .auto-style12 {
            height: 26px;
            width: 292px;
        }
        .auto-style13 {
            height: 945px;
        }
        .auto-style14 {
            height: 83px;
            width: 174px;
        }
        .auto-style15 {
            width: 292px;
            height: 83px;
        }
        .auto-style16 {
            height: 106px;
            width: 174px;
        }
        .auto-style17 {
            width: 292px;
            height: 106px;
        }
        .auto-style18 {
            width: 174px;
        }
    </style>
</head>
<body>
    <form id="registerdev" runat="server" style="background-color: slategray" enctype="multipart/form-data">
        <div class="auto-style5">
            <asp:ScriptManager ID="ScriptManager2" runat="server" EnablePageMethods="True">
            </asp:ScriptManager>
            <fieldset class="auto-style13">
        <table>
            <tr><td style="background-color:orange; border:1px solid orange" class="auto-style18"><h3 style="text-align:center">
                Registration form</h3></td><td style="background-color:orange" class="auto-style8">as a developer</td></tr>

            <tr><td class="auto-style18"><asp:label runat="server" Text="Username" ID="label1"></asp:label>(*)</td>
                <td class="auto-style8"><asp:TextBox runat="server" ID="username1"
                    placeholder="State your username"></asp:TextBox></td></tr>

            <tr><td class="auto-style18"><asp:label runat="server" Text="Password" ID="label2"></asp:label>(*)</td>
                <td class="auto-style8"><asp:TextBox runat="server" ID="pass1" TextMode="Password"></asp:TextBox></td></tr>

            <tr><td class="auto-style18"><asp:label runat="server" Text="Confirm Password" ID="label3"></asp:label>(*)</td>
                <td class="auto-style8"><asp:TextBox runat="server" ID="passw2" TextMode="Password"></asp:TextBox></td></tr>
            
            <tr><td class="auto-style18"><asp:label runat="server" Text="E-mail" ID="label4"></asp:label>(*)</td>
                <td class="auto-style8"><asp:TextBox runat="server" ID="email1"
                    placeholder="E-mail"></asp:TextBox></td><td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="emailcheck"/></td></tr>

            <tr><td class="auto-style18"><asp:label runat="server" Text="Name" ID="label5"></asp:label></td>
                <td class="auto-style8"><asp:TextBox runat="server" ID="firstname1"
                    placeholder="Name"></asp:TextBox></td></tr>

            <tr><td class="auto-style1"><asp:label runat="server" Text="Surname" ID="label6"></asp:label></td>
                <td class="auto-style9"><asp:TextBox runat="server" ID="lastname1"
                    placeholder="Surname"></asp:TextBox></td><td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="namecheck"/></td></tr>
            <tr><td class="auto-style1">Gender</td><td style="text-align:left" class="auto-style9">
                <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
                <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Female" />
                </td><td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="genderCheck"/></td></tr>
            <tr><td class="auto-style3">Profile Image</td><td class="auto-style10">
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style4" />
                
                <br/>
                </td></tr>

            <tr><td class="auto-style6">Skills</td><td class="auto-style11">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="auto-style7" Font-Size="Small" Height="16px" Width="98px">
                    <asp:ListItem>C#</asp:ListItem>
                    <asp:ListItem>Java</asp:ListItem>
                    <asp:ListItem>HTML5</asp:ListItem>
                    <asp:ListItem>Python</asp:ListItem>
                    <asp:ListItem>php</asp:ListItem>
                    <asp:ListItem>c++</asp:ListItem>
                    <asp:ListItem>CSS</asp:ListItem>
                </asp:CheckBoxList>
                <br />
                extra skills:
                <br />
                <asp:TextBox ID="TextBox3" runat="server" Height="53px" Width="257px"></asp:TextBox>
                <br />
                <br />
                </td></tr>
            <tr><td class="auto-style18">CV</td><td class="auto-style8">
                <asp:FileUpload ID="FileUpload2" runat="server" CssClass="auto-style4" />
                
                </td><td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="Cvcheck"/></td></tr>
            <tr><td class="auto-style16">Portfolio</td><td class="auto-style17">   <asp:TextBox runat="server" ID="port"
                    placeholder="example.com" Height="73px" Width="279px"></asp:TextBox>   </td><td><asp:CheckBox runat="server" Text="Visible by others" Checked="true" ID="portcheck"/></td></tr>
            <tr><td class="auto-style2">
                <br />
                </td><td class="auto-style12"><input type="checkbox" name="term" id="term">
                <label>I agree with the user terms.(*)</label></td></tr>


            <tr><td class="auto-style14">
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Small" Text="(*)All fields with an asterisk must be completed."></asp:Label>
                </td><td class="auto-style15"><asp:Button runat="server" style="background-color:red;color:white;" Text="Cancel" ID="Button1" OnClick="cancelBack" />
                <asp:Button style="background-color:green;color:white;" id="makeDev" runat="server" Text="Confirm" OnClick="makeDev_Click" />
                    <br />
                    <br />
                </td></tr>

        </table>
    </fieldset><br><br>
        </div>
    </form>
    
</body>
</html>
