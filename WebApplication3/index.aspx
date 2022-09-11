<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication3.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"href="style.css">
    <title>getDev</title>
</head>
<body>
    <img width="120px" height="100px" src="getDev.png">
    <form action="login.aspx>
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Log In</button>
                </td>
            </tr>
        </table>
    </form>
    <form action="register.aspx">
        <table class="table1">
            <tr>
                <td>
                    <button class="editbtn">Register</button>
                </td>
            </tr>
        </table>
    </form>
    <br />
    <form action="" style="background-color: lightseagreen;text-align:center">
        <h1 style="color: white">Find someone to help you create your dream project</h1>
        <input type="text" id="userid" name="user">
        <input type="submit" id="user" value="Search" style="border: none;background-color:white;font-size: 15px;">
    </form>
    <br />
    <form action="" style="background-color: lightseagreen;text-align:center">
        <h1 style="color: white">Find a project to contribute on</h1>
        <input type="text" id="projectid" name="project">
        <input type="submit" id="project" value="Search" style="border: none;background-color:white;font-size: 15px;">
    </form>
    <br />
</body>
</html>

