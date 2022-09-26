<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchingDevProfilePage.aspx.cs" Inherits="WebApplication3.searchingDevProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Search a Developer:        "></asp:Label>
        <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Sort By Joined Date" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Sort By Skills" />
        <asp:DropDownList runat="server" ID="subcategory">
                    <asp:ListItem>C#</asp:ListItem><asp:ListItem>Java</asp:ListItem>
                    <asp:ListItem>c++</asp:ListItem><asp:ListItem>php</asp:ListItem><asp:ListItem>Python</asp:ListItem>
                    <asp:ListItem>HTML 5</asp:ListItem><asp:ListItem>CSS</asp:ListItem><asp:ListItem>web designer</asp:ListItem>
                    <asp:ListItem>web developer</asp:ListItem><asp:ListItem>algorythms</asp:ListItem>
        </asp:DropDownList>
        <asp:Panel ID="MotherPanel" runat="server" Height="248px">
            <asp:Table ID="TableShow" runat="server" Height="243px" Width="961px">
            </asp:Table>
        </asp:Panel>
    </form>
</body>
</html>
