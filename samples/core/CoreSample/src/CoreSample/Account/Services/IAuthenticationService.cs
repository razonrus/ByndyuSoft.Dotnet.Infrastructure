namespace CoreSample.Account.Services
{
    public interface IAuthenticationService
    {
        void SignIn(User user, bool createPersistentCookie);
        void SignOut();
    }
}