using AutoMapper;
using ProjectVally.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Web.Http;
using ProjectVally.Application.Interface;

namespace ProjectVally.API.Controllers
{
    public class ApiControllerBase<TViewModel, TEntity>: ApiController where TViewModel : class where TEntity : class
    {
        private readonly IAppServiceBase<TEntity> _appServiceBase;
        
        public ApiControllerBase(IAppServiceBase<TEntity> appServiceBase)
        {
            _appServiceBase = appServiceBase;
        }

        protected IEnumerable<TViewModel> GetAll()
        {
            var viewModel = Mapper.Map<IEnumerable<TEntity>, IEnumerable<TViewModel>>(_appServiceBase.GetAll());
            return viewModel;
        }

        protected TViewModel GetViewModelById(int id)
        {
            var entity = _appServiceBase.GetById(id);
            return GetViewModelByEntity(entity);
        }

        protected TViewModel GetViewModelByEntity(TEntity entity)
        {
            return Mapper.Map<TEntity, TViewModel>(entity);
        }

        protected TEntity GetEntityByViewModel(TViewModel viewModel)
        {
            return Mapper.Map<TViewModel, TEntity>(viewModel);
        }

        protected bool EntityExists(int id)
        {
            return _appServiceBase.GetById(id) != null;
        }
    }
}