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
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

    }
}