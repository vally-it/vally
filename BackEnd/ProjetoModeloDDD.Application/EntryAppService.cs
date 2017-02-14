using ProjectVally.Application.Interface;
using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Application
{
    public class EntryAppService: AppServiceBase<Entry>, IEntryAppService
    {
        private readonly IEntryService _entryService;

        public EntryAppService(IEntryService entryService):base(entryService)
        {
            _entryService = entryService;
        }
    }
}
