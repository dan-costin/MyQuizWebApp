using MyQuiz.Model;

namespace MyQuiz.Repository
{
    public interface IQuizRepository
    {
        void SaveQuiz(Quiz quiz);
    }
}
