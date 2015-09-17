using MyQuiz.Repository;
using MyQuiz.UiEntities;

namespace MyQuiz.Services
{
    public interface IQuizService
    {
        QuestionWrapper NextQuestion { get; set; }
        void SetQuiz(IQuizRepository quizRepository, int quizId);
        void GetNextQuestion();
        void AnswerQuestion();
    }
}