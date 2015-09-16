using System;
using MyQuiz.Repository;
using MyQuiz.Services;

namespace MyQuiz.Views
{
    public partial class SignUpWebForm : System.Web.UI.Page
    {
        IUserRepository _UserRepository;
        ILoginService _LoginService;

        public SignUpWebForm(IUserRepository userRepository, ILoginService loginService)
        {
            _UserRepository = userRepository;
            _LoginService = loginService;
        }

        public SignUpWebForm()
        {
            _UserRepository = ModelContainer.Resolve<IUserRepository>();
            _LoginService = ModelContainer.Resolve<ILoginService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SignUpUser(object sender, EventArgs e)
        {
            if (_UserRepository.RegisterNewUser(username.Text, email.Text, password.Text))
            {
                _LoginService.LoginUser(this.Request, this.Response, username.Text, password.Text);
            }
        }

    }
}