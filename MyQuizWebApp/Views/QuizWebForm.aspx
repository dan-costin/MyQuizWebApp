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
            <asp:Label ID="questionText" Text="<%#QuizService.NextQuestion.Question.QuestionText %>" runat="server" />
        </div>

        <br />
        <div style="width: 100%;">
            <div style="display: inline; float: left;">
                <div class="quizCheckClass">
                    <asp:CheckBox Text="<%#QuizService.NextQuestion.Question.Answer1 %>" Checked="<%#QuizService.NextQuestion.Answer.Answer1 %>" ID="answer1" runat="server" CssClass="quizCheckClass" />
                </div>
                <br />
                <div class="quizCheckClass">
                    <asp:CheckBox Text="<%#QuizService.NextQuestion.Question.Answer2 %>" Checked="<%#QuizService.NextQuestion.Answer.Answer2 %>" ID="answer2" runat="server" CssClass="quizCheckClass" />
                </div>
            </div>
            <div style="display: inline; float: left;">
                <div class="quizCheckClass">
                    <asp:CheckBox Text="<%#QuizService.NextQuestion.Question.Answer3 %>" Checked="<%#QuizService.NextQuestion.Answer.Answer3 %>" ID="answer3" runat="server" />
                </div>
                <br />
                <div class="quizCheckClass">
                    <asp:CheckBox Text="<%#QuizService.NextQuestion.Question.Answer4 %>" Checked="<%#QuizService.NextQuestion.Answer.Answer4 %>" ID="answer4" runat="server" CssClass="quizCheckClass" />
                </div>
            </div>
        </div>

        <asp:Button Text="Next Question" CssClass="greenButtonStyle" runat="server" Style="float: right; margin-top: 50px; margin-right: 200px;" OnClick="NextQuestionClicked" />
    </form>
</asp:Content>
