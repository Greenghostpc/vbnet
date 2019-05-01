<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="shirt.aspx.vb" Inherits="WebApplication453534534.shirt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/shirt.jpg" style="z-index: 1; left: 488px; top: 42px; position: absolute; height: 132px; width: 134px" />
            <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 540px; top: 192px; position: absolute" Text="Shirt"></asp:Label>
        </div>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 536px; top: 229px; position: absolute" Text="$15.99"></asp:Label>
    </form>
</body>
</html>
