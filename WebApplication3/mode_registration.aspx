<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mode_registration.aspx.cs" Inherits="WebApplication3.Mode_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <style type="text/css">
        #clientframe {
            height: 493px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <asp:Label ID="Label1" runat="server" BackColor="#33CCCC" BorderColor="#E1E1E1" Font-Bold="True" Font-Size="XX-Large" Height="68px" style="text-align:center" Text="Registering as :" Width="100%"></asp:Label>
        </div>
        <div>
        <p>
            <asp:Label ID="Label2" runat="server" style="text-align:center" Font-Bold="True" Font-Size="XX-Large" Text="" Width="100%" ></asp:Label>
        </p>
        </div>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
        <p>
            <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="Large" Height="63px" style="margin-left: 251px" Text="Client" Width="195px" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="Large" Height="59px" style="margin-left: 488px" Text="Developer" Width="185px" OnClick="Button4_Click" />
        </p>
     <iframe runat="server" id="clientframe" width="100%"></iframe>   
    </form>
</body>
</html>
