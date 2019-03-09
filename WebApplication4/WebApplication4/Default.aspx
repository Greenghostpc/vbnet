<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Joseph&#39;s Website</h1>
        <p class="lead">Welcome to my website!</p>
        <p><a href="About.aspx" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Shop</h2>
            <p>
                Buy our products!</p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Shop &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Donate</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://paypal.me/emeraldtnt">Donate &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>GitHub</h2>
            <p>
                You can easily find other applications and src code that I created at my GitHub page.
            </p>
            <p>
                <a class="btn btn-default" href="https://github.com/josephworks">GitHub &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
