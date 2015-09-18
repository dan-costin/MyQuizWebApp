using System;
using System.Web;
using MyQuiz.Model;
using MyQuiz.Repository;
using System.Collections.Generic;

namespace MyQuiz.Views
{
    public partial class CreateQuizWebForm : System.Web.UI.Page
    {
        IQuizRepository _QuizRepository;
        IUserRepository _UserRepository;

        private List<Question> _Questions;

        protected void Page_Load(object sender, EventArgs e)
        {
            var viewStateQuestions = (List<Question>)ViewState["Questions"];
            saveQuizButton.Visible = false;
            saveQuizLabel.Visible = true;
            if (viewStateQuestions != null)
            {
                _Questions = viewStateQuestions;
                if (_Questions.Count >= 2)
                {
                    saveQuizButton.Visible = true;
                    saveQuizLabel.Visible = false;
                }
            }
            pageTitle.Text = $"Question 1";
        }

        public CreateQuizWebForm()
        {
            _QuizRepository = ModelContainer.Resolve<IQuizRepository>();
            _UserRepository = ModelContainer.Resolve<IUserRepository>();
            _Questions = new List<Question>();
        }

        protected void AddQuestionClicked(object sender, EventArgs e)
        {
            Question newQuestion = new Question();
            newQuestion.QuestionText = question.Text;
            Answer firstAnswer = new Answer() { AnswerText = answer1.Text, IsAnswerCorrect = check1.Checked };
            Answer secondAnswer = new Answer() { AnswerText = answer2.Text, IsAnswerCorrect = check2.Checked };
            Answer thirdAnswer = new Answer() { AnswerText = answer3.Text, IsAnswerCorrect = check3.Checked };
            Answer fourthAnswer = new Answer() { AnswerText = answer4.Text, IsAnswerCorrect = check4.Checked };

            _Questions.Add(newQuestion);
            ViewState["Questions"] = _Questions;

            pageTitle.Text = $"Question {_Questions.Count + 1}";
            ClearFields();
        }

        protected void SaveQuizClicked(object sender, EventArgs e)
        {
            var quiz = new Quiz();
            quiz.Name = quizName.Text;
            quiz.NumberOfQuestions = _Questions.Count;
            quiz.CreationDate = DateTime.Now;
            quiz.Questions = _Questions;
            quiz.Owner = GetUser();

            _QuizRepository.SaveQuiz(quiz);

            if (ViewState["Questions"] != null)
            {
                ViewState["Questions"] = null;
            }

            Server.Transfer("HomeWebForm.aspx");
        }

        private void ClearFields()
        {
            question.Text = string.Empty;
            answer1.Text = string.Empty;
            answer2.Text = string.Empty;
            answer3.Text = string.Empty;
            answer4.Text = string.Empty;
            check1.Checked = false;
            check2.Checked = false;
            check3.Checked = false;
            check4.Checked = false;
        }

        private User GetUser()
        {
            HttpCookie myCookie = Request.Cookies["MyQuizCookie"];

            if (myCookie == null)
            {
                return null;
            }
            if (string.IsNullOrEmpty(myCookie.Values["userid"]))
            {
                return null;
            }

            string userId = myCookie.Values["userid"].ToString();
            User user = _UserRepository.GetUser(Convert.ToInt32(userId));

            return user;
        }
    }
}