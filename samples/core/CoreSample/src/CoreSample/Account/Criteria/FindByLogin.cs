using ByndyuSoft.Infrastructure.Domain;

namespace CoreSample.Account.Criteria
{
    public class FindByLogin : ICriterion
    {
        public string Login { get; set; }
    }
}