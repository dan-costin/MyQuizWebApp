<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="QuizListWebForm.aspx.cs" Inherits="MyQuiz.Views.QuizListWebForm" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Header" ContentPlaceHolderID="header" runat="server">
    <link href="../Styles/ListViewStyleSheet.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Label Text="quiz list" runat="server" />

    <form runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
        <telerik:RadAjaxPanel runat="server" LoadingPanelID="RadAjaxLoadingPanel1">
            <telerik:RadGrid ID="quizGridView" runat="server" AllowFilteringByColumn="True" AllowSorting="True" Width="100%"
                ShowFooter="false" AllowPaging="True">
                <MasterTableView AutoGenerateColumns="false" TableLayout="Fixed" AllowFilteringByColumn="True" ShowFooter="True">
                    <Columns>
                        <telerik:GridButtonColumn CommandName="StartQuiz" Text="Start quiz" HeaderText="Start" ButtonType="PushButton">
                            <HeaderStyle Width="100px" />
                        </telerik:GridButtonColumn>
                        <telerik:GridBoundColumn DataField="Name" HeaderText="Name" ShowFilterIcon="false" CurrentFilterFunction="Contains" 
                            AutoPostBackOnFilter="true">
                            <HeaderStyle Width="50%" />
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Owner.UserName" HeaderText="Created by" ShowFilterIcon="false" CurrentFilterFunction="Contains" 
                            AutoPostBackOnFilter="true">
                            <HeaderStyle Width="30%" />
                        </telerik:GridBoundColumn>
                        <telerik:GridDateTimeColumn DataField="CreationDate" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date Created" 
                            ShowFilterIcon="false" CurrentFilterFunction="EqualTo" AutoPostBackOnFilter="true">
                            <HeaderStyle Width="20%" />
                        </telerik:GridDateTimeColumn>
                        <telerik:GridBoundColumn DataField="NumberOfQuestions" HeaderText="Questions" ShowFilterIcon="false" 
                            CurrentFilterFunction="EqualTo" AutoPostBackOnFilter="true">
                            <HeaderStyle Width="120px" />
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn HeaderText="Rating" ShowFilterIcon="false" AllowFiltering="false">
                            <ItemTemplate>
                                <%--<%# Convert.ToDouble(Eval("AverageRating")) %>--%>
                                <%--<%# Convert.ToBoolean(Eval("isRated")) %>--%>
                                <telerik:RadRating ID="RadRating1" runat="server" AutoPostBack="true" Value='3'
                                    Precision="Exact" ReadOnly="true">
                                </telerik:RadRating>
                            </ItemTemplate>
                            <HeaderStyle Width="120px" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
        </telerik:RadAjaxPanel>
    </form>
</asp:Content>
