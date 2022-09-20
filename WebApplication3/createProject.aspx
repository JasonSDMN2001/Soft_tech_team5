<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createProject.aspx.cs" Inherits="WebApplication3.createProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="createProject" runat="server">
        <h2>Create your own Project</h2>
        <asp:Table runat="server">
            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="*Title:"/></asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="title"/></asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="*Description:"/></asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="proj_description"/></asp:TableCell></asp:TableRow>
            
            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="*Visible by others:"/></asp:TableCell><asp:TableCell><asp:RadioButtonList runat="server" ID="publicity">
                    <asp:ListItem>Public</asp:ListItem><asp:ListItem>Private</asp:ListItem>
                               </asp:RadioButtonList></asp:TableCell></asp:TableRow>

            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="*Do you want to view prices offered by developers?"/></asp:TableCell><asp:TableCell><asp:RadioButtonList runat="server" ID="view_offer">
                    <asp:ListItem>Yes</asp:ListItem><asp:ListItem>No</asp:ListItem>
                               </asp:RadioButtonList></asp:TableCell></asp:TableRow>

            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="*Category:"/></asp:TableCell><asp:TableCell><asp:DropDownList runat="server"  autopostback="true" onselectedindexchanged="category_SelectedIndexChanged" ID="category">
                    <asp:ListItem>Web Site</asp:ListItem><asp:ListItem>Database</asp:ListItem>
                    <asp:ListItem>Mobile app</asp:ListItem><asp:ListItem>Security</asp:ListItem>
                               </asp:DropDownList></asp:TableCell></asp:TableRow>

            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="*Subcategory:"/></asp:TableCell><asp:TableCell><asp:DropDownList runat="server" ID="subcategory">
                    <asp:ListItem>Blog</asp:ListItem><asp:ListItem>Corporate</asp:ListItem>
                    <asp:ListItem>Ecommerce</asp:ListItem><asp:ListItem>Portal</asp:ListItem><asp:ListItem>Video Streaming</asp:ListItem>
                                </asp:DropDownList></asp:TableCell></asp:TableRow>

            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="*Payment Method:"/></asp:TableCell><asp:TableCell><asp:RadioButtonList runat="server" ID="payment_method">
                    <asp:ListItem>Hourly</asp:ListItem><asp:ListItem>Salary</asp:ListItem>
                               </asp:RadioButtonList></asp:TableCell></asp:TableRow>

            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Max Price:"/></asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="maxprice"/></asp:TableCell></asp:TableRow>
            
            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="Duration of Development:"/></asp:TableCell><asp:TableCell><asp:DropDownList runat="server" ID="devduration">
                    <asp:ListItem>Less than a week</asp:ListItem><asp:ListItem>1-4 weeks</asp:ListItem>
                    <asp:ListItem>1-3 months</asp:ListItem><asp:ListItem>3-6 months</asp:ListItem>
                    <asp:ListItem>6-12 months</asp:ListItem><asp:ListItem>Over a year</asp:ListItem><asp:ListItem>I don't know</asp:ListItem>
                               </asp:DropDownList></asp:TableCell></asp:TableRow>

            <asp:TableRow><asp:TableCell><asp:Label runat="server" Text="How long will this project be open for offers?:"/></asp:TableCell><asp:TableCell><asp:DropDownList runat="server" ID="offerduration">
                    <asp:ListItem>Less than a week</asp:ListItem><asp:ListItem>1-4 weeks</asp:ListItem>
                    <asp:ListItem>1-3 months</asp:ListItem><asp:ListItem>3-6 months</asp:ListItem>
                    <asp:ListItem>6-12 months</asp:ListItem><asp:ListItem>Over a year</asp:ListItem><asp:ListItem>Indefinetely</asp:ListItem>
                               </asp:DropDownList></asp:TableCell></asp:TableRow>

        </asp:Table><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" /></form>
    <h6>* these fields must be filled in order for the project to be submitted</h6>
</body>
</html>
