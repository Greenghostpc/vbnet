<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="WebApplication453534534.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 547px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="Image4" runat="server" Height="138px" ImageUrl="~/cup.jpg" Width="139px" />
        <asp:Image ID="Image5" runat="server" Height="138px" ImageUrl="~/backpack.jpg" Width="139px" style="z-index: 1; left: 673px; top: 41px; position: absolute" />
        <asp:Image ID="Image6" runat="server" Height="138px" ImageUrl="~/maneennload.jpg" Width="139px" />
        <asp:Image ID="Image7" runat="server" Height="138px" ImageUrl="~/walletad.jpg" Width="139px" style="z-index: 1; left: 836px; top: 39px; position: absolute" />
        <asp:Image ID="Image8" runat="server" Height="125px" ImageUrl="~/dowgrfgfrfgnload.png" Width="90px" style="z-index: 1; left: 281px; top: 95px; position: absolute" />
        <asp:Image ID="Image9" runat="server" Height="138px" ImageUrl="~/downleroad (1).jpg" Width="139px" style="z-index: 1; left: 378px; top: 34px; position: absolute" />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/shirt.jpg" style="z-index: 1; left: 527px; top: 42px; position: absolute; height: 132px; width: 134px" />
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 887px; top: 190px; position: absolute; right: 176px" Text="Wallet"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 14px; top: 191px; position: absolute" Text="Rick And Morty Cup"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 198px; top: 190px; position: absolute; height: 19px" Text="Sweatpants"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 300px; top: 194px; position: absolute" Text="Soccer ball"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 426px; top: 192px; position: absolute" Text="Car"></asp:Label>
            <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 569px; top: 192px; position: absolute" Text="Shirt"></asp:Label>
            <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 701px; top: 192px; position: absolute" Text="Backpack"></asp:Label>
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://localhost:58423/WebForm3">Cup Details</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="http://localhost:58423/pants.aspx" style="z-index: 1; left: 177px; top: 230px; position: absolute">Sweatpants Details</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="http://localhost:58423/ball.aspx" style="z-index: 1; left: 310px; top: 226px; position: absolute">Ball Details</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="http://localhost:58423/car.aspx" style="z-index: 1; left: 405px; top: 226px; position: absolute; height: 20px">Car Details</asp:HyperLink>
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="http://localhost:58423/shirt.aspx" style="z-index: 1; left: 553px; top: 227px; position: absolute">Shirt Details</asp:HyperLink>
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="http://localhost:58423/bag.aspx" style="z-index: 1; top: 227px; position: absolute; left: 680px">Backpack Details</asp:HyperLink>
        <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="http://localhost:58423/wallet" style="z-index: 1; left: 876px; top: 228px; position: absolute; width: 78px">Wallet Detail</asp:HyperLink>
    </form>
</body>
</html>
