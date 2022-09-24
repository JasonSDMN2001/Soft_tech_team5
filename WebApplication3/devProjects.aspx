<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="devProjects.aspx.cs" Inherits="WebApplication3.devProjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 116px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
    </style>
</head>
<body style="margin-top: 37px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Choose your desired category:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="auto-style2" Height="61px" Width="105px">
                <asp:ListItem>Active</asp:ListItem>
                <asp:ListItem>Inactive</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Table ID="Table1" runat="server" Height="398px" Width="711px">
        </asp:Table>
    </form>
</body>
</html>
