using System.Web;

namespace MyQuiz.Services
{
    public interface ILoginService
    {
        void LoginUser(HttpRequest request, HttpResponse response, string username, string password);
    }
}
