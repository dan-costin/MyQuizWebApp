using System;
using System.Web;
using MyQuiz.Repository;

namespace MyQuiz.Services
{
    public class LoginService : ILoginService
    {
        IUserRepository _UserRepository;

        public LoginService(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public void LoginUser(HttpRequest request, HttpResponse response, string username, string password)
        {
            var result = _UserRepository.LogInUser(username, password);
            if (result > 0)
            {
                AddCookie(request, response, result.ToString());
                response.Redirect("HomeWebForm.aspx");
            }
        }

        private void AddCookie(HttpRequest request, HttpResponse response, string userId)
        {
            HttpCookie myCookie = request.Cookies["MyQuizCookie"];
            if (myCookie == null)
            {
                myCookie = new HttpCookie("MyQuizCookie");
            }

            myCookie.Values.Clear();
            myCookie.Values.Add("userid", userId);
            myCookie.Expires = DateTime.Now.AddHours(12);
            response.AppendCookie(myCookie);
        }
    }
}