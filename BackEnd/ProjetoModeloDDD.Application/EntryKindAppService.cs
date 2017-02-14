using ProjectVally.Application.Interface;
using ProjectVally.Domain.Entities;
using ProjectVally.Domain.Interfaces.Services;

namespace ProjectVally.Application
{
    public class EntryKindAppService: AppServiceBase<EntryKind>, IEntryKindAppService
    {
        private readonly IEntryKindService _entryKindService;

        public EntryKindAppService(IEntryKindService entryKindService):base(entryKindService)
        {
            _entryKindService = entryKindService;
        }
    }
}
