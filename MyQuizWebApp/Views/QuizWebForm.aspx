<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="QuizWebForm.aspx.cs" Inherits="MyQuiz.Views.QuizWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
    <link href="../Styles/QuizStyleSheet.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form runat="server">
        <div class="defaultLabelStyle">
            <asp:Label ID="label" runat="server" Text="Question 1" />
        </div>

        <div class="defaultLabelStyle">
            <asp:Label ID="questionText" runat="server" />
        </div>

        <br />
        <div style="width: 100%;">
            <div style="width: 50%; display: inline; float: left;">
                <div class="quizCheckClass">
                    <asp:CheckBox Text="Answer1" ID="answer1" runat="server" CssClass="quizCheckClass" />
                </div>
                <br />
                <div class="quizCheckClass">
                    <asp:CheckBox Text="Answer2" ID="answer2" runat="server" CssClass="quizCheckClass" />
                </div>
            </div>
            <div style="width: 50%; display: inline; float: left;">
                <div class="quizCheckClass">
                    <asp:CheckBox Text="Answer3" ID="answer3" runat="server" />
                </div>
                <br />
                <div class="quizCheckClass">
                    <asp:CheckBox Text="Answer4" ID="answer4" runat="server" CssClass="quizCheckClass" />
                </div>
            </div>
        </div>

        <asp:Button Text="Next Question" CssClass="greenButtonStyle" runat="server" Style="float: right; margin-top: 50px; margin-right:200px;" OnClick="NextQuestionClicked"/>
    </form>
</asp:Content>
