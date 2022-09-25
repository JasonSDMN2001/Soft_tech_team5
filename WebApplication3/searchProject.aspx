<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchProject.aspx.cs" Inherits="WebApplication3.searchProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .auto-style1 {
            height: 458px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="browsebtn" runat="server" BackColor="White" Enabled="False" Text="Browse Projects" OnClick="browsebtn_Click" />
            <asp:Button ID="searchbtn" runat="server" BorderColor="Gray" OnClick="searchbtn_Click" Text="Search a Project" />
        </div>
        <iframe runat="server" id="resframe" width="100%" class="auto-style1" src="viewAllProjects.aspx"></iframe>
    </form>
</body>
</html>
