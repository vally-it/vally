using AutoMapper;
using ProjectVally.API.ViewModels;
using ProjectVally.Domain.Entities;

namespace ProjectVally.API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public DomainToViewModelMappingProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<AccountViewModel, Account>();
            CreateMap<AccountKindViewModel, AccountKind>();
            CreateMap<EntryKindViewModel, EntryKind>();
            CreateMap<EntryViewModel, Entry>();

        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

    }
}