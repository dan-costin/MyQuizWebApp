<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="SignUpWebForm.aspx.cs" Inherits="MyQuiz.Views.SignUpWebForm" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="header" runat="server">
    <link href="../Styles/SignUpStyleSheet.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div>
        <div id="pageTitle">
            <asp:Label Text="Join My Quiz" runat="server" />
        </div>
        <form runat="server" style="display: grid">
            <div class="headerText">
                <asp:Label Text="Username" runat="server" />
            </div>
            <div class="inputText">
                <asp:TextBox Width="500px" Height="20px" runat="server" />
            </div>
            <div class="descriptionText">
                <asp:Label Text="This will be your username." runat="server" />
            </div>

            <div class="headerText">
                <asp:Label Text="Email Address" runat="server" />
            </div>
            <div class="inputText">
                <asp:TextBox Width="500px" Height="20px" runat="server" />
            </div>
            <div class="descriptionText">
                <asp:Label Text="You will occasionally receive account related emails." runat="server" />
            </div>

            <div class="headerText">
                <asp:Label Text="Password" runat="server" />
            </div>
            <div class="inputText">
                <asp:TextBox Width="500px" Height="20px" runat="server" />
            </div>
            <div class="descriptionText">
                <asp:Label Text="Use at least one lowercase letter, one numeral, and seven characters." runat="server" />
            </div>

            <div class="headerText">
                <asp:Label Text="Confirm your password" runat="server" />
            </div>
            <div class="inputText">
                <asp:TextBox Width="500px" Height="20px" runat="server" />
            </div>

            <br />

            <div class="termsAndConditionsText">
                <asp:Label Text="By clicking on Create an account below, you are agreeing to the Terms of Service and the Privacy Policy.." runat="server" />
            </div>

            <input type="button" id="createAccount" value="Create account" />
        </form>
    </div>
</asp:Content>
