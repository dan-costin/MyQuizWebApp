using System;
using MyQuiz.Repository;

namespace MyQuiz.Views
{
    public partial class SignUpWebForm : System.Web.UI.Page
    {
        IUserRepository _UserRepository;

        public SignUpWebForm(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public SignUpWebForm()
        {
            _UserRepository = ModelContainer.Resolve<IUserRepository>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SignUpUser(object sender, EventArgs e)
        {
            _UserRepository.RegisterNewUser(username.Text, email.Text, password.Text);
        }
    }
}