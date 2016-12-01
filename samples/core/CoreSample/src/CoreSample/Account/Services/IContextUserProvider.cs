namespace CoreSample.Account.Services
{
    public interface IContextUserProvider
    {
        User ContextUser();
        User ContextUser(bool shouldThrow);
    }
}