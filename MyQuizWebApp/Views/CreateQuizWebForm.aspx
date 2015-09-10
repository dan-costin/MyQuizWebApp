<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="CreateQuizWebForm.aspx.cs" Inherits="MyQuiz.Views.CreateQuizWebForm" %>

<asp:Content ID="Header" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form runat="server">
        <asp:Label Text="Question" runat="server" />
        <p>
            <asp:Label Text="What is the question?" runat="server" />
            <asp:TextBox runat="server" />
        </p>
        <p>
            <asp:Label Text="Answer 1" runat="server" />
            <asp:TextBox runat="server"/>
        </p>
    </form>
</asp:Content>
