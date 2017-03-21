using AutoMapper;
using ProjectVally.API.ViewModels;
using ProjectVally.Domain.Entities;

namespace ProjectVally.API.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<Account, AccountViewModel>();
            CreateMap<AccountKind, AccountKindViewModel>();
            CreateMap<EntryKind, EntryKindViewModel>();
            CreateMap<Entry, EntryViewModel>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}