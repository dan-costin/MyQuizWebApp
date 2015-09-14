using MyQuiz.Model;
using System.Collections.Generic;

namespace MyQuiz.Repository
{
    public interface IQuizRepository
    {
        void SaveQuiz(Quiz quiz);
        List<Quiz> GetAllQuizzes();
        Quiz GetQuiz(int quizId);
    }
}
