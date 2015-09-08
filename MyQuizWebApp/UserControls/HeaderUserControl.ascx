<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderUserControl.ascx.cs" Inherits="MyQuiz.UserControls.HeaderUserControl" %>

<div id="logoHeader">
    <div style="display: inline; float: left; width: 20%;">
        <asp:Label Text="My Quiz" runat="server" />
    </div>
    <div style="display: inline; float: right; width: 80%; margin-bottom: -30px; width: 570px;">
        <ul id="menu">
            <li><a href="HomeWebForm.aspx">Home</a></li>
            <li><a href="HomeWebForm.aspx">Categories</a></li>
            <li><a href="HomeWebForm.aspx">Products</a></li>
            <li><a href="HomeWebForm.aspx">About Us</a></li>
            <li><a href="HomeWebForm.aspx">Contact Us</a></li>
        </ul>
    </div>
    <div style="clear: both;"></div>
</div>
