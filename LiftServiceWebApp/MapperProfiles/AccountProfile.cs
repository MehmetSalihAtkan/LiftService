using AutoMapper;
using LiftService.Models.Identity;
using LiftService.ViewModels;

namespace LiftService.MapperProfiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<ApplicationUser, UserProfileViewModel>().ReverseMap();
            //CreateMap<UserProfileViewModel, ApplicationUser>(); //reversemap kullandığımız için gerek yok
        }
    }
}
