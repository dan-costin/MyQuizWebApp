using System;
using MyQuiz.Repository;
using System.Web;

namespace MyQuiz.Views
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        IUserRepository _UserRepository;

        public LoginWebForm(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public LoginWebForm()
        {
            _UserRepository = ModelContainer.Resolve<IUserRepository>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignInUserClick(object sender, EventArgs e)
        {
            var result = _UserRepository.SignInUser(username.Text, password.Text);

            HttpCookie myCookie = new HttpCookie("MyQuizCookie");

            myCookie.Values.Add("userid", result.ToString());

            myCookie.Expires = DateTime.Now.AddHours(12);

            Response.Cookies.Add(myCookie);
        }
    }
}