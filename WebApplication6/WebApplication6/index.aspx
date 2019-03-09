<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="WebApplication6.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FFFF66">
    <form id="form1" runat="server">
        <div style="text-align: center; background-color: #FFFF66">
            <h1>Carpet and Flooring</h1>
            <h2>We Bake the best carpets!</h2>
            <h3>Address: 8080 West Joseph Wai</h3>
            <h2>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="pricing.aspx">Pricing</asp:HyperLink>
            </h2>
            <p>
                <asp:Image ID="Image1" runat="server" Height="306px" ImageUrl="~/Carpet.jpg" Width="752px" />
            </p>
        </div>
    </form>
</body>
</html>
