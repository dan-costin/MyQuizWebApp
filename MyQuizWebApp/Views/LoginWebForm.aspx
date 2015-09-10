<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="LoginWebForm.aspx.cs" Inherits="MyQuiz.Views.LoginWebForm" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="header" runat="server">
    <link href="../Styles/SignInStyleSheet.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">

    <div style="width: 50%; max-width: 400px; height: 250px; align-content: center; margin: auto">
        <div id="pageTitle">
            <asp:Label Text="Sign in" runat="server" />
        </div>
        <div id="signInFormStyle">
            <form runat="server" style="display: grid">

                <div class="defaultLabelStyle">
                    <asp:Label Text="Username or Email" runat="server" />
                </div>
                <div class="defaultTextBoxStyle">
                    <asp:TextBox ID="username" Width="90%" Height="20px" runat="server" Font-Names="Segoe UI" Font-Size="16px"/>
                </div>

                <div class="defaultLabelStyle">
                    <asp:Label Text="Password" runat="server" />
                </div>
                <div class="defaultTextBoxStyle">
                    <asp:TextBox ID="password" Width="90%" Height="20px" runat="server" Font-Names="Segoe UI" Font-Size="16px" TextMode="Password" />
                </div>

                <div style="margin-top: 20px;">
                    <asp:Button OnClick="SignInUserClick" Text="Sign in" runat="server" CssClass="greenButtonStyle" />
                </div>
            </form>
        </div>
    </div>

</asp:Content>
