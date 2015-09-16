using MyQuiz.Model;
using MyQuiz.Repository;
using MyQuiz.Services;
using System;
using System.Collections.Generic;

namespace MyQuiz.Views
{
    public partial class QuizWebForm : System.Web.UI.Page
    {
        IQuizRepository _QuizRepository;
        IQuizService _QuizService;

        public QuizWebForm()
        {
            _QuizRepository = ModelContainer.Resolve<IQuizRepository>();
            _QuizService = new QuizService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var quizId = Session["QuizId"];
            if (quizId != null)
            {
                LoadQuestions((int)quizId);
            }
            else
            {
                _QuizService = (IQuizService)ViewState["QuizService"];
            }
            LoadNextQuestion();
            ViewState["QuizService"] = _QuizService;
        }

        private void LoadQuestions(int quizId)
        {
            Session.Remove("QuizId");
            _QuizService.SetQuiz(_QuizRepository.GetQuiz(quizId));
        }

        private void LoadNextQuestion()
        {
            Question question = _QuizService.GetNextQuestion();

            if (question == null)
            {
                return;
            }

            questionText.Text = question.QuestionText;
            answer1.Text = question.Answer1;
            answer2.Text = question.Answer2;
            answer3.Text = question.Answer3;
            answer4.Text = question.Answer4;
        }

        protected void NextQuestionClicked(object sender, EventArgs e)
        {
            _QuizService.AnswerQuestion(answer1.Checked, answer2.Checked, answer3.Checked, answer4.Checked);
        }
    }
}