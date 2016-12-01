using CoreSample.Account.Forms;

namespace CoreSample.Account.Profiles
{
    public class UserProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(x => x.Name, x => x.MapFrom(z => z.Name));
        }
    }
}