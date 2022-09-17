﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clientMainPage.aspx.cs" Inherits="WebApplication3.clientMainPage" %>

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
            height: 204px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div></div>
            <table width="100%" style="background-color:cornflowerblue">
                <tr><td><asp:Button runat="server" Text="Your Profile" ID="profileShow" class="opt" OnClick="profileShow_Click" /></td>
                <td><asp:Button runat="server" Text="Make a Project" ID="createProject" class="opt" /></td>
                <td><asp:Button runat="server" Text="Edit your Projects" ID="editProject" class="opt" /></td></tr>
                <tr><td><asp:Button runat="server" Text="Search a Developer" ID="searchDev" class="opt" /></td>
                    <td><asp:Button runat="server" Text="Search another User" ID="searchClient" class="opt" /></td>
                <td><asp:Button runat="server" Text="Search a Project" ID="searchProject" class="opt" /></td></tr>
            </table>
            <iframe runat="server" id="clientframe" src="indexing.aspx" width="100%"></iframe>
    </form>
</body>
</html>