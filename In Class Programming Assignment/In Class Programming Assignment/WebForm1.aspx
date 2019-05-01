<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="In_Class_Programming_Assignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: x-small;
        }
    </style>
</head>
<body style="background-color: #FFFF00">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1><strong>Yeethan&#39;s
                <br />
                <asp:Label ID="Label1" runat="server" Text="Carpet and Flooring"></asp:Label>
                </strong></h1>
            <p>
                <b class="auto-style2" style="color: rgb(34, 34, 34); font-family: Roboto, arial, sans-serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">1124 Random Rd</b><span class="auto-style2" style="color: rgb(34, 34, 34); font-family: Roboto, arial, sans-serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">. El Cajon, 
                CA 92020.</span></p>
        </div>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/carpenter.jpg" style="z-index: 1; left: 317px; top: 131px; position: absolute; height: 142px; width: 162px" />
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://localhost:54562/WebForm2.aspx" style="z-index: 1; left: 339px; top: 297px; position: absolute">Cost Estimator</asp:HyperLink>
        </p>
    </form>
</body>
</html>
