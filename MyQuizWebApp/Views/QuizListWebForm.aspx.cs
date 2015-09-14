using System;
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
    }
}