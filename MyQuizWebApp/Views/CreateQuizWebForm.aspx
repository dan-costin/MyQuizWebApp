<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="CreateQuizWebForm.aspx.cs" Inherits="MyQuiz.Views.CreateQuizWebForm" %>

<asp:Content ID="Header" ContentPlaceHolderID="header" runat="server">
    <link href="../Styles/CreateQuizStyleSheet.css" rel="stylesheet" />

    <script>
        function saveQuiz() {
            if (document.getElementById('<%= quizName.ClientID %>').style.display === 'none') {
                document.getElementById('<%= quizName.ClientID %>').style.display = 'inline';
                return false;
            }
            return true;
        }

        function addQuestion() {
            var areValidItems = true;
            if (document.getElementById('<%= question.ClientID %>').value === "") {
                document.getElementById('<%= questionError.ClientID %>').style.display = 'inline';
                areValidItems = false;
            }
            else {
                document.getElementById('<%= questionError.ClientID %>').style.display = 'none';
            }

            if (document.getElementById('<%= answer1.ClientID %>').value === "") {
                document.getElementById('<%= answer1error.ClientID %>').style.display = 'inline';
                areValidItems = false;
            }
            else {
                document.getElementById('<%= answer1error.ClientID %>').style.display = 'none';
            }

            if (document.getElementById('<%= answer2.ClientID %>').value === "") {
                document.getElementById('<%= answer2error.ClientID %>').style.display = 'inline';
                areValidItems = false;
            }
            else {
                document.getElementById('<%= answer2error.ClientID %>').style.display = 'none';
            }

            if (document.getElementById('<%= answer3.ClientID %>').value === "") {
                document.getElementById('<%= answer3error.ClientID %>').style.display = 'inline';
                areValidItems = false;
            }
            else {
                document.getElementById('<%= answer3error.ClientID %>').style.display = 'none';
            }

            if (document.getElementById('<%= answer4.ClientID %>').value === "") {
                document.getElementById('<%= answer4error.ClientID %>').style.display = 'inline';
                areValidItems = false;
            }
            else {
                document.getElementById('<%= answer4error.ClientID %>').style.display = 'none';
            }

            return areValidItems;
        }
    </script>

</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form runat="server">
        <asp:Label ID="pageTitle" runat="server" CssClass="pageTitleClass" />
        <p>
            <asp:Label Text="What is the question?" runat="server" CssClass="quizLabelStyle" />
            <asp:TextBox ID="question" placeholder="Question" runat="server" CssClass="quizTextBoxStyle" />
            <img src="../Assets/error.bmp" width="20" height="20" title="Please insert the question here." style="display: none;" id="questionError" runat="server" />
        </p>
        <p>
            <asp:Label Text="Answer 1" runat="server" CssClass="quizLabelStyle" />
            <asp:TextBox ID="answer1" placeholder="First answer" runat="server" CssClass="quizTextBoxStyle" />
            <asp:CheckBox ID="check1" ToolTip="Correct answer" runat="server" />
            <img src="../Assets/error.bmp" width="20" height="20" title="Please insert the first answer here." style="display: none;" id="answer1error" runat="server" />
        </p>
        <p>
            <asp:Label Text="Answer 2" runat="server" CssClass="quizLabelStyle" />
            <asp:TextBox ID="answer2" placeholder="Second answer" runat="server" CssClass="quizTextBoxStyle" />
            <asp:CheckBox ID="check2" ToolTip="Correct answer" runat="server" />
            <img src="../Assets/error.bmp" width="20" height="20" title="Please insert the second answer here." style="display: none;" id="answer2error" runat="server" />
        </p>
        <p>
            <asp:Label Text="Answer 3" runat="server" CssClass="quizLabelStyle" />
            <asp:TextBox ID="answer3" placeholder="Third answer" runat="server" CssClass="quizTextBoxStyle" />
            <asp:CheckBox ID="check3" ToolTip="Correct answer" runat="server" />
            <img src="../Assets/error.bmp" width="20" height="20" title="Please insert the third answer here." style="display: none;" id="answer3error" runat="server" />
        </p>
        <p>
            <asp:Label Text="Answer 4" runat="server" CssClass="quizLabelStyle" />
            <asp:TextBox ID="answer4" placeholder="Fourth answer" runat="server" CssClass="quizTextBoxStyle" />
            <asp:CheckBox ID="check4" ToolTip="Correct answer" runat="server" />
            <img src="../Assets/error.bmp" width="20" height="20" title="Please insert the fourth answer here." style="display: none;" id="answer4error" runat="server" />
        </p>

        <div class="defaultLabelStyle" style="margin-left: 33%; font-weight: normal; font-size: 14px;">
            <asp:Label Text="Check the correct answers." runat="server" />
        </div>

        <div style="display: inline; float: right; margin-top: 20px;">
            <asp:Button ID="saveQuizButton" Text="Save Quiz" CssClass="grayButtonStyle" BorderWidth="1px" runat="server" OnClick="SaveQuizClicked" OnClientClick="return saveQuiz()" />
            <asp:Label ID="saveQuizLabel" Text="Your quiz must have at least three questions." runat="server" Visible="false" />
            <asp:TextBox ID="quizName" placeholder="Enter quiz name" runat="server" CssClass="quizTextBoxStyle" Style="display: none; width: 200px;" />

            <asp:Button Text="Add question" CssClass="greenButtonStyle" runat="server" OnClick="AddQuestionClicked" OnClientClick="return addQuestion()" />
        </div>
    </form>
</asp:Content>
