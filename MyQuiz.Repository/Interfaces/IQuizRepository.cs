using MyQuiz.Model;
using System.Collections.Generic;

namespace MyQuiz.Repository
{
    public interface IQuizWrapper
    {
        void SaveQuiz(Quiz quiz);
        List<Quiz> GetAllQuizzes();
        Quiz GetQuiz(int quizId);
    }
}
