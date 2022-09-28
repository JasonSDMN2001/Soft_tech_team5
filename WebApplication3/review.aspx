<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="review.aspx.cs" Inherits="WebApplication3.review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Review our Developer</title>
    <style type="text/css">

        .auto-style2 {
            margin-left: 230px;
        }
        .auto-style3 {
            margin-left: 355px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1 style="color: white; background-color: lightseagreen;text-align:center">Review our Developer</h1>

                
            </center>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Rate stars:1 of 5"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" >
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Leave a comment"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Height="72px" Width="208px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Submit " />
        </p>
    </form>
</body>
</html>
