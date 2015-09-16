using MyQuiz.Model;
using System.Runtime.Serialization;

namespace MyQuiz.Services
{
    public interface IQuizService
    {
        void SetQuiz(Quiz quiz);
        Question GetNextQuestion();
        void AnswerQuestion(bool question1, bool question2, bool question3, bool question4);
    }
}