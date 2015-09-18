using System;
using MyQuiz.Model;
using Telerik.Web.UI;
using MyQuiz.Repository;

namespace MyQuiz.Views
{
    public partial class QuizListWebForm : System.Web.UI.Page
    {
        IQuizRepository _QuizRepository;

        protected void Page_Init(object sender, EventArgs e)
        {
            _QuizRepository = ModelContainer.Resolve<IQuizRepository>();
            var quizzes = _QuizRepository.GetAllQuizzes();
            quizGridView.DataSource = quizzes;
            quizGridView.DataBind();
        }

        protected void quizGridView_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "StartQuiz")
            {
                GridDataItem item = (GridDataItem)e.Item;
                if (item == null)
                {
                    return;
                }
                Quiz quiz = (Quiz)item.DataItem;
                Session["QuizId"] = quiz.ID;
                Response.Redirect("QuizWebForm.aspx");
            }
        }
    }
}