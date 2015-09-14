using MyQuiz.Model;
using MyQuiz.Repository;
using System;
using System.Collections.Generic;

namespace MyQuiz.Views
{
    public partial class QuizWebForm : System.Web.UI.Page
    {
        IQuizRepository _QuizRepository;
        int questionIndex = 0;
        Quiz _Quiz;

        public QuizWebForm()
        {
            _QuizRepository = ModelContainer.Resolve<IQuizRepository>();
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

            }
            LoadNextQuestion();
        }

        private void LoadQuestions(int quizId)
        {
            Session.Remove("QuizId");
            _Quiz = _QuizRepository.GetQuiz(quizId);
        }

        private void LoadNextQuestion()
        {
            Question question = GetItemAtIndex(_Quiz.Questions, questionIndex);
            if (question == null)
            {
                return;
            }

            questionIndex++;
            questionText.Text = question.QuestionText;
            answer1.Text = question.Answer1;
            answer2.Text = question.Answer2;
            answer3.Text = question.Answer3;
            answer4.Text = question.Answer4;
        }

        private Question GetItemAtIndex(ICollection<Question> collection, int index)
        {
            int collectionIndex = 0;
            foreach (Question question in _Quiz.Questions)
            {
                if (index == collectionIndex)
                    return question;
                collectionIndex++;
            }
            return null;
        }
    }
}