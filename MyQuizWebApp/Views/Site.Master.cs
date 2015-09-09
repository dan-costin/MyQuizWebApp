using System;
using System.Web;

namespace MyQuiz.Views
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookie = Request.Cookies["MyQuizCookie"];
            if (myCookie == null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(myCookie.Values["userid"]))
            {
                string userId = myCookie.Values["userid"].ToString();
            }
        }
    }
}