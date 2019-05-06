<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Wide Latin";
        }
        .auto-style2 {
            text-align: center;
            background-color: #FFFF66;
        }
    </style>
</head>
<body style="background-color: #CCFF66">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <h1 class="auto-style2">Greenview Toy Store</h1>
            <div class="auto-style2">
                <br />
            </div>
            <h2 class="auto-style2">333 Main Street<br />
                Chicago, IL 60611<br />
                (111)555-5555</h2>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://localhost:61697/WebForm2.aspx">Store Hours</asp:HyperLink>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" BorderColor="#CCFF33" Height="226px" ImageUrl="~/Small_house.jpg" Width="192px" />
        </div>
    </form>
</body>
</html>
