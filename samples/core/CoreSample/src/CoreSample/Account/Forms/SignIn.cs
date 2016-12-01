using ByndyuSoft.Infrastructure.Web.Forms;

namespace CoreSample.Account.Forms
{
    public class SignIn : IForm
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}