using System;
using MyQuiz.Services;
using MyQuiz.Repository;

namespace MyQuiz.Views
{
    public partial class QuizWebForm : System.Web.UI.Page
    {
        IQuizWrapper _QuizRepository;
        public IQuizService QuizService { get; set; }

        public QuizWebForm()
        {
            _QuizRepository = ModelContainer.Resolve<IQuizWrapper>();
            QuizService = ModelContainer.Resolve<IQuizService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var quizId = Session["QuizId"];
            if (quizId != null)
            {
                QuizService.SetQuiz(_QuizRepository, (int)quizId);
                Session.Remove("QuizId");
            }
            else
            {
                QuizService = (IQuizService)ViewState["QuizService"];
            }

            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            QuizService.GetNextQuestion();
            DataBind();
            ViewState["QuizService"] = QuizService;
        }

        protected void NextQuestionClicked(object sender, EventArgs e)
        {
            QuizService.AnswerQuestion();
            DataBind();
        }
    }
}