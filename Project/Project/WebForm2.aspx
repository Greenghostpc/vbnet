<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: x-large;
            font-weight: normal;
            font-style: italic;
            text-align: center;
        }
        .auto-style3 {
            font-size: large;
            font-weight: bold;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
            <h1 class="auto-style2">Please visit during these hours:</h1>
            <div class="auto-style4">
                <br />
                <br />
                <span class="auto-style3">Monday - Friday 8am - 10pm</span><br class="auto-style3" />
                <span class="auto-style3">Saturday 9am - 6pm</span><br class="auto-style3" />
                <span class="auto-style3">Closed Sunday</span></div>
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="http://localhost:61697/WebForm1.aspx" style="z-index: 1; left: 348px; top: 181px; position: absolute">Previous Page</asp:LinkButton>
    </form>
</body>
</html>
