<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: justify">
    <form id="form1" runat="server">
        <center><div style="background-color: #FFFFCC">
            <h1>Greenview Toy Store</h1>
            <h2>&nbsp;</h2>
            <p>
                <strong style="color:darkgreen;">333 Main Street
                <br />
                Chicago, IL 60611
                <br />
                (111) 555-5555
            </strong>
            </p>
            <p>
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WebForm2.aspx">Store Hours</asp:LinkButton>
            &nbsp;-
                <asp:HyperLink ID="HyperLink1" runat="server">Currency Converter</asp:HyperLink>
            </p>
            <p>
                <asp:Image ID="Image1" runat="server" BackColor="Black" BorderColor="#FFFFCC" BorderStyle="Groove" BorderWidth="10px" Height="287px" ImageUrl="~/Small_house.jpg" Width="193px" />
            </p>
        </div></center>
    </form>
</body>
</html>
