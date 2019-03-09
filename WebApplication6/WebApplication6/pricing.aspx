<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pricing.aspx.vb" Inherits="WebApplication6.pricing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FFFF66">
    <form id="form1" runat="server">
        <div>
            <div style="height: 588px; text-align: center; margin-bottom: 50px">
                <h1>Carpet and Flooring</h1>
                <h2>Pricing</h2>
                <p>
                    <asp:ListBox ID="ListBox1" runat="server" Height="77px" Width="137px">
                        <asp:ListItem>Carpet - $5 per Sq.Ft</asp:ListItem>
                        <asp:ListItem>Wood - $15 per Sq.Ft</asp:ListItem>
                        <asp:ListItem>Tile - $3 per Sq.Ft</asp:ListItem>
                        <asp:ListItem>Glass - $25 per Sq.Ft</asp:ListItem>
                    </asp:ListBox>
                </p>
                <p>
                    <asp:Label ID="Label1" runat="server" Text="Length:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </p>
                <p>
                    Width: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="Label5" runat="server" Text="Price: "></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Calculate" />
                </p>
                <p>
                    <asp:Label ID="Label2" runat="server" Text="Area: "></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="35"></asp:Label>
                </p>
                <p>
                    Cost:
                    <asp:Label ID="Label4" runat="server" Text="47.95"></asp:Label>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
