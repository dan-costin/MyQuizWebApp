using System;
using System.Web;
using MyQuiz.Repository;
using MyQuiz.Services;

namespace MyQuiz.Views
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        IUserRepository _UserRepository;
        ILoginService _LoginService;

        public LoginWebForm(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
            _LoginService = new LoginService(_UserRepository);
        }

        public LoginWebForm()
        {
            _UserRepository = ModelContainer.Resolve<IUserRepository>();
            _LoginService = new LoginService(_UserRepository);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SignInUserClick(object sender, EventArgs e)
        {
            _LoginService.LoginUser(this.Request, this.Response, username.Text, password.Text);
        }
    }
}