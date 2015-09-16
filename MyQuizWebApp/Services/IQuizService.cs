using MyQuiz.Model;
using MyQuiz.Repository;
using MyQuiz.UiEntities;

namespace MyQuiz.Services
{
    public interface IQuizService
    {
        Answers Answer { get; set; }
        QuestionWrapper NextQuestion { get; set; }
        void SetQuiz(IQuizWrapper quizRepository, int quizId);
        void GetNextQuestion();
        void AnswerQuestion();
    }
}