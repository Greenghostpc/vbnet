<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="In_Class_Programming_Assignment.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 453px; background-color: #FFFF00">
    <form id="form1" runat="server">
        <div style="background-color: #FFFF00">
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 296px; top: 74px; position: absolute; bottom: 695px"></asp:TextBox>
        <asp:RadioButton ID="RadioButton1" runat="server" style="z-index: 1; left: 110px; top: 36px; position: absolute" Text="Marble ($1.37 per sqft)" />
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; top: 76px; position: absolute; left: 150px" Text="Length"></asp:Label>
            <asp:RadioButton ID="RadioButton3" runat="server" style="z-index: 1; left: 454px; top: 37px; position: absolute" Text="Ceramic ($8.99 per sqft)" />
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 296px; top: 74px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 297px; top: 114px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 150px; top: 114px; position: absolute; width: 34px; height: 19px" Text="Width"></asp:Label>
        <asp:RadioButton ID="RadioButton2" runat="server" style="z-index: 1; left: 288px; top: 37px; position: absolute" Text="Wood ($3.99 per sqft)" />
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 306px; top: 164px; position: absolute" Text="Calculate" />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 329px; top: 209px; position: absolute" Text="$47.95"></asp:Label>
        <p>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 9px; top: 331px; position: absolute; font-size: 88pt" Text="Cost Estimator"></asp:Label>
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://localhost:54562/WebForm1" style="z-index: 1; left: 325px; top: 289px; position: absolute">Previous Page</asp:HyperLink>
    </form>
</body>
</html>
