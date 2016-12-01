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
        public ActionResult SignIn(SignIn command)
        {
            return Form(command, this.RedirectToAction("Index", "Home"));
        }
    }
}