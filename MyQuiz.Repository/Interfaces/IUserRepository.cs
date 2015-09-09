namespace MyQuiz.Repository
{
    public interface IUserRepository
    {
        bool SignUpUser(string username, string email, string password);
        int SignInUser(string username, string password);
    }
}
