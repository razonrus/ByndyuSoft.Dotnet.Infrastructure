using Microsoft.AspNetCore.Mvc;
using ByndyuSoft.Infrastructure.Web.Forms;
using CoreSample.Account.Forms;

namespace CoreSample.Controllers
{
    public class AccountController : FormControllerBase
    {
        public AccountController(IFormHandlerFactory formHandlerFactory)
            : base(formHandlerFactory)
        {
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(SignIn command, string returnUrl)
        {
            return Form(command, GetRedirectResult(returnUrl));
        }

        [CustomAuthorize]
        public ActionResult SignOut(SignOut command)
        {
            return Form(command, this.RedirectToAction("Profile"));
        }

        [CustomAuthorize]
        public ActionResult Profile()
        {
            return View();
        }

        private ActionResult GetRedirectResult(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return this.RedirectToAction("Profile");
        }
    }
}