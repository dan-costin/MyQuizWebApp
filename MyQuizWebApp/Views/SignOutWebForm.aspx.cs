using System;
using System.Web;

namespace MyQuiz.Views
{
    public partial class SignOutWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookie = Request.Cookies["MyQuizCookie"];
            if (myCookie != null)
            {
                Response.Cookies.Remove("MyQuizCookie");
                myCookie.Expires = DateTime.Now.AddDays(-10);
                myCookie.Values.Clear();
                myCookie.Value = null;
                Response.SetCookie(myCookie);
            }
            Response.Redirect("HomeWebForm.aspx");
        }
    }
}