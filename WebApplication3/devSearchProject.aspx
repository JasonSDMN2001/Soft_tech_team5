<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="devSearchProject.aspx.cs" Inherits="WebApplication3.devSearchProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            height: 458px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Button ID="browsebtn" runat="server" BackColor="White" Enabled="False" Text="Browse Projects" OnClick="browsebtn_Click" />
            <asp:Button ID="searchbtn" runat="server" BorderColor="Gray" OnClick="searchbtn_Click" Text="Search a Project" />
        </div>
        <iframe runat="server" id="projframe" width="100%" class="auto-style1" src="devViewAllProjects.aspx" name="I1"></iframe>
    </form>
    
</body>
</html>
