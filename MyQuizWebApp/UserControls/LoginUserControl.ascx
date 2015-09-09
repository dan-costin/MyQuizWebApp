<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUserControl.ascx.cs" Inherits="MyQuiz.UserControls.LoginUserControl" %>

<%--<% LogOutUser(); %> --%>

<div id="registerForm" style="display: inline; float: right;" runat="server">
    <button id="signUpButton" onclick="signUp()">Sign up</button>
    <button id="signInButton" onclick="signIn()">Sign in</button>
</div>
<div id="registeredForm" style="display: none; float: right;" runat="server">
    <asp:Label ID="helloUsernameText" runat="server" />
    <button id="signOut" onclick="signOut()" runat="server">Sign out</button>
</div>
