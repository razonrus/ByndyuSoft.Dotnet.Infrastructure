using AutoMapper;
using CoreSample.Account.Forms;
using CoreSample.Domain.Model.Entities;

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