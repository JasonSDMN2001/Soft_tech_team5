<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="devMainPage.aspx.cs" Inherits="WebApplication3.devMainPage" %>



<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
    <style>
        .opt {
            background-color:white;
            display:block;
            margin:auto;
            Width:45%;
            font-weight: bold;
        }
        #clientframe {
            height: 571px;
            margin-bottom: 109px;
        }
        .auto-style1 {
            height: 475px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table width="100%" style="background-color:cornflowerblue">
                <tr><td><asp:Button runat="server" Text="Your Profile" ID="profileShow" class="opt" OnClick="profileShow_Click" /></td>
                <td><asp:Button runat="server" Text="rating" ID="rating" class="opt" /></td>
                <td><asp:Button runat="server" Text="Edit submitted offers" ID="editoffers" class="opt" /></td></tr>
                <tr><td><asp:Button runat="server" Text="Projects in progress" ID="projinprogress" class="opt" OnClick="projinprogress_Click" /></td>
                    <td><asp:Button runat="server" Text="Search another User" ID="searchuser" class="opt" /></td>
                <td><asp:Button runat="server" Text="Search a Project" ID="searchProject" class="opt" /></td></tr>
            </table>
            <iframe runat="server" id="clientframe" width="100%" class="auto-style1"></iframe>
    </form>
</body>
</html>