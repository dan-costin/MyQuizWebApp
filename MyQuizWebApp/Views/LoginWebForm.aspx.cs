using System;
using System.Web;
using MyQuiz.Repository;

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
            AddCookie(result.ToString());
            Server.Transfer("HomeWebForm.aspx");
        }

        private void AddCookie(string userId)
        {
            HttpCookie myCookie = Request.Cookies["MyQuizCookie"];
            if (myCookie == null)
            {
                myCookie = new HttpCookie("MyQuizCookie");
            }

            myCookie.Values.Clear();
            myCookie.Values.Add("userid", userId);
            myCookie.Expires = DateTime.Now.AddHours(12);
            Response.AppendCookie(myCookie);
        }
    }
}