using AutoMapper;
using ProjectVally.Domain.Entities;
using ProjectVally.MVC.ViewModels;

namespace ProjectVally.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {

        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

    }
}