<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Currency.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif">
            <asp:Image ID="Image1" runat="server" Height="145px" ImageUrl="~/USflag.jpg" Width="336px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Currency Converter"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="American Dollars:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 143px; top: 198px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="British Pounds:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 140px; top: 236px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>
