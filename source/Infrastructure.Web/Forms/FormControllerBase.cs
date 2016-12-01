using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ByndyuSoft.Infrastructure.Web.Forms
{
    using System;

    public class FormControllerBase : Controller
    {
        private const string ModelStateKey = "ModelState";
        private readonly IFormHandlerFactory _formHandlerFactory;

        protected FormControllerBase(IFormHandlerFactory formHandlerFactory)
        {
            this._formHandlerFactory = formHandlerFactory;
        }

        protected  ActionResult Form<TForm>(TForm form, ActionResult sucessResult) where TForm : IForm
        {
            return Form(form, () => sucessResult);
        }

        protected ActionResult Form<TForm>(TForm form, ActionResult sucessResult, ActionResult failResult) where TForm : IForm
        {
            return Form(form, () => sucessResult, () => failResult);
        }

        protected ActionResult Form<TForm>(TForm form, Func<ActionResult> successResult) where TForm : IForm
        {
            return Form(form, successResult, () => Redirect(Request.Headers["Referer"].ToString()));
        }

        protected ActionResult Form<TForm>(TForm form, Func<ActionResult> successResult, Func<ActionResult> failResult) where TForm : IForm
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _formHandlerFactory.Create<TForm>().Execute(form);

                    return successResult();
                }
                catch (FormHandlerException fhe)
                {
                    var key = string.IsNullOrEmpty(fhe.Key) ? "form" : fhe.Key;
                    ModelState.AddModelError(key, fhe.Message);
                }
            }

            return failResult();
        }
    }
}