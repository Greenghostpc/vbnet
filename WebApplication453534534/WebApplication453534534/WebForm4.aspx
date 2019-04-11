<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm4.aspx.vb" Inherits="WebApplication453534534.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cups:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Sweatpants:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Soccerball:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Car:<asp:TextBox ID="TextBox4" runat="server" Height="22px"></asp:TextBox>
            <br />
            <br />
            shirts:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            Backpacks:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            Wallets:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Total:"></asp:Label>
            <asp:Label ID="totalLabel" runat="server" style="z-index: 1; left: 69px; top: 291px; position: absolute" Text="0.00"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 10px; top: 374px; position: absolute" Text="Checkout" />
    </form>
</body>
</html>
