<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUserControl.ascx.cs" Inherits="MyQuiz.UserControls.LoginUserControl" %>

<div id="registerForm" style="display: inline; float: right;" runat="server">
    <button id="signUpButton" class="greenButtonStyle" onclick="signUp()">Sign up</button>
    <button id="signInButton" class="grayButtonStyle" onclick="signIn()">Sign in</button>
</div>

<div id="registeredForm" style="display: none; float: right;" runat="server">
    <asp:Label ID="helloUsernameText" runat="server" />
    <button id="signOutButton" class="greenButtonStyle" onclick="signOut()" runat="server">Sign out</button>
</div>