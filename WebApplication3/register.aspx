<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication3.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"href="style.css">
    <title>Register</title>
    <style type="text/css">

        .auto-style3 {
            height: 96px;
            width: 202px;
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
        .auto-style7 {
            width: 5px;
            height: 38px;
        }
        .auto-style8 {
            height: 38px;
        }
        .auto-style9 {
            margin-left: 163px;
        }
        .auto-style10 {
            width: 202px;
        }
        .auto-style11 {
            height: 38px;
            width: 202px;
        }
        .auto-style12 {
            height: 26px;
            width: 202px;
        }
        .auto-style13 {
            height: 665px;
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
                <td><asp:TextBox runat="server" ID="pass" TextMode="Password"></asp:TextBox></td></tr>

            <tr><td class="auto-style10"><asp:label runat="server" Text="Confirm Password"></asp:label>(*)</td>
                <td><asp:TextBox runat="server" ID="pass2" TextMode="Password"></asp:TextBox></td></tr>
            
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
                <asp:TextBox runat="server" ID="gender"
                    placeholder="Gender ♀ ♂" CssClass="auto-style9" Width="16px"></asp:TextBox></td></tr>
            <tr><td class="auto-style11"><label>Date of Birth</label></td><td class="auto-style8"><select name="day" id="day!"><option select name="imera">Day
                <option value="1">1</option>
                <option value="2">2</option><option value="3">3</option><option value="4">4</option>
                <option value="5">5</option><option value="6">6</option><option value="7">7</option>
                <option value="8">8</option><option value="9">9</option><option value="10">10</option>
                <option value="11">11</option><option value="12">12</option><option value="13">13</option>
                <option value="14">14</option><option value="15">15</option><option value="16">16</option>
                <option value="17">17</option><option value="18">18</option><option value="19">19</option>
                <option value="20">20</option><option value="21">21</option><option value="22">22</option>
                <option value="23">23</option><option value="24">24</option><option value="25">25</option>
                <option value="26">26</option><option value="27">27</option><option value="28">29</option>
                <option value="30">30</option><option value="31">31</option></select><select name="month" id="month!">
                    <option selected value="minas">Month
                    <option value="January">January</option>
                    <option value="February">February</option>
                    <option value="March">March</option><option value="April">April</option>
                    <option value="May">May</option><option value="June">June</option>
                    <option value="July">July</option><option value="August">August</option>
                    <option value="September">September</option><option value="October">October</option>
                    <option value="November">November</option><option value="December">December</option></select><select name="year" id="year!"><option select name="etos">Year
                    <option value="1990">1990</option><option value="1991">1991</option>
                    <option value="1992">1992</option><option value="1993">1993</option>
                    <option value="1994">1994</option><option value="1995">1995</option>
                    <option value="1996">1996</option><option value="1997">1997</option>
                    <option value="1998">1998</option><option value="1999">1999</option>
                    <option value="2000">2000</option><option value="2001">2001</option>
                    <option value="2002">2002</option></select></td>
                <td class="auto-style8"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr><td class="auto-style3">Profile Image</td><td style="text-align:left">
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style4" />
                
              <asp:Button ID="Button2" runat="server" Text="Upload File" OnClick="UploadFile" /><br/>
            <asp:Image ID="image" runat="server" Height="92px" Width="176px"  /></td></tr>
            <tr><td class="auto-style10">Descreption</td><td><asp:TextBox runat="server" ID="desc"
                    placeholder="state something" Height="70px"></asp:TextBox></td></tr>
            <tr><td class="auto-style10">Link</td><td><asp:TextBox runat="server" ID="link"
                    placeholder="link"></asp:TextBox></td></tr>



            <tr><td class="auto-style12"></td><td class="auto-style6"><input type="checkbox" name="term" id="term">
                <label>I agree with the user terms</label></td></tr>


            <tr><td class="auto-style10">&nbsp;</td><td><asp:Button runat="server" style="background-color:red;color:white;" Text="Cancel" ID="back" OnClick="cancelBack" />
                <asp:Button style="background-color:green;color:white;" id="makeUser" runat="server" Text="Confirm" OnClick="makeUser_Click" /></td></tr>

        </table>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" Text="(*)All fields with an asterisk must be completed."></asp:Label>
    </fieldset><br><br>
        </div>
    </form>
</body>
</html>
 
