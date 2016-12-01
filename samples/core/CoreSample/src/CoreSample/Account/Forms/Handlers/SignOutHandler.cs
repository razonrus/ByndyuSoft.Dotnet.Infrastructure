using ByndyuSoft.Infrastructure.Web.Forms;
using CoreSample.Account.Services;

namespace CoreSample.Account.Forms.Handlers
{
    public class SignOutHandler : IFormHandler<SignOut>
    {
        private readonly IAuthenticationService _authenticationService;

        public SignOutHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public virtual void Execute(SignOut command)
        {
            _authenticationService.SignOut();
        }
    }
}