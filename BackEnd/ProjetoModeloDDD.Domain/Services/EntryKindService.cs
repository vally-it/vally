using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repository;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class EntryKindService: ServiceBase<EntryKind>, IEntryKindService
    {
        private readonly IEntryKindRepository _entryKindRepository;

        public EntryKindService(IEntryKindRepository entryKindRepository)
            : base(entryKindRepository)
        {
            _entryKindRepository = entryKindRepository;
        }

    }
}
