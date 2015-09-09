using MyQuiz.Model;

namespace MyQuiz.Repository
{
    public interface IUserRepository
    {
        bool RegisterNewUser(string username, string email, string password);

        int LogInUser(string username, string password);

        User GetUser(int userId);
    }
}
