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
                <div class="headerText">
                    <asp:Label Text="Username or Email" runat="server" />
                </div>
                <div class="inputText">
                    <asp:TextBox ID="username" Width="90%" Height="20px" runat="server" />
                </div>

                <div class="headerText">
                    <asp:Label Text="Password" runat="server" />
                </div>
                <div class="inputText">
                    <asp:TextBox ID="password" Width="90%" Height="20px" runat="server" TextMode="Password"/>
                </div>

                <asp:Button OnClick="SignInUserClick" Text="Sign in" runat="server" CssClass="signInButtonStyle" />
            </form>
        </div>
    </div>

</asp:Content>
