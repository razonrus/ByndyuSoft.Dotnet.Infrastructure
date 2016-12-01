using ByndyuSoft.Infrastructure.Web.Forms;
using CoreSample.Account.Criteria;
using ByndyuSoft.Infrastructure.Domain;
using CoreSample.Domain.Model.Entities;

namespace CoreSample.Account.Forms.Handlers
{
    public class SignInHandler : IFormHandler<SignIn>
    {
        private readonly IQueryBuilder _queryBuilder;
        
        public SignInHandler(IQueryBuilder queryBuilder)
        {
            _queryBuilder = queryBuilder;
        }

        public virtual void Execute(SignIn command)
        {
            User user = _queryBuilder.For<User>()
                                     .With(new FindByLogin {Login = command.Login});

            if (user != null)
                throw new FormHandlerException("Login is already used");
        }
    }
}