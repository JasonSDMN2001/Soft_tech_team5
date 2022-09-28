    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication3.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"href="style.css">
    <title>getDev</title>
</head>
<body>
    <img width="120px" height="100px" src="getDev.png">
    <form action="login.aspx">
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Log In</button>
                </td>
            </tr>
        </table>
    </form>
    <form action="mode_registration.aspx">
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Register</button>
                </td>
            </tr>
        </table>
    </form>
    <br />
    <h1 style="color: white; background-color: lightseagreen;text-align:center">Find someone to help you create your dream project</h1>
    <form action="searchingDevProfilePage.aspx" >
        
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Search</button>
                </td>
            </tr>
        </table>
    </form>
    <br />
    <h1 style="color: white;background-color: lightseagreen;text-align:center">Find a Project</h1>
    <form action="devSearchProjectUnreg.aspx">
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Search</button>
                </td>
            </tr>
        </table>
    </form>
    <h1 style="color: white; background-color: lightseagreen;text-align:center">Search a User</h1>
    <form action="searchingProfilePage.aspx" >
        
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Search</button>
                </td>
            </tr>
        </table>
    </form>
    <br />
</body>
</html>

