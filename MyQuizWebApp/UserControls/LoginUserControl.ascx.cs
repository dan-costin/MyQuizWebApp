using MyQuiz.Model;
using MyQuiz.Repository;
using System;
using System.Web;
using System.Web.UI.WebControls;

namespace MyQuiz.UserControls
{
    public partial class LoginUserControl : System.Web.UI.UserControl
    {
        IUserRepository _UserRepository;

        public LoginUserControl()
        {
            _UserRepository = ModelContainer.Resolve<IUserRepository>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            TryLogInFromCookie();
        }

        private void TryLogInFromCookie()
        {
            HttpCookie myCookie = Request.Cookies["MyQuizCookie"];

            registerForm.Style.Add("display", "inline");
            registeredForm.Style.Add("display", "none");

            if (myCookie == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(myCookie.Values["userid"]))
            {
                return;
            }

            string userId = myCookie.Values["userid"].ToString();

            User user = _UserRepository.GetUser(Convert.ToInt32(userId));

            registerForm.Style.Add("display", "none");
            registeredForm.Style.Add("display", "inline");
            helloUsernameText.Text = $"Hello {user.UserName} ";
        }
    }
}