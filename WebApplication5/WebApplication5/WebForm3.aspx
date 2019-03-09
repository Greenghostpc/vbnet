<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="WebApplication5.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="290px" ImageUrl="~/USflag.jpg" Width="324px" />
            <h1 ID="Label1" runat="server" style="z-index: 1; left: 395px; top: 72px; position: absolute; height: 50px; width: 330px" Text="Currency Converter">Currency Converter</h1>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 399px; top: 143px; position: absolute" Text="Americal Dollars:"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 402px; top: 172px; position: absolute" Text="British Pounds:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 509px; top: 142px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 509px; top: 173px; position: absolute"></asp:TextBox>
        </div>
    </form>
</body>
</html>
