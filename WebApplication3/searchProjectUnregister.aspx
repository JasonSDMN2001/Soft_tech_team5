<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchProjectUnregister.aspx.cs" Inherits="WebApplication3.searchProjectUnregister" %>

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
            <asp:Button ID="browsebtn2" runat="server" BackColor="White" Enabled="False" Text="Browse Projects" OnClick="browsebtn_Click2" />
            <asp:Button ID="searchbtn2" runat="server" BorderColor="Gray" OnClick="searchbtn_Click2" Text="Search a Project" />
        </div>
        <iframe runat="server" id="resframe2" width="100%" class="auto-style1" src="viewAllProjects.aspx"></iframe>
    </form>
</body>
</html>
