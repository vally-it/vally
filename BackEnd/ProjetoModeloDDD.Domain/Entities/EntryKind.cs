
namespace ProjetoModeloDDD.Domain.Entities
{
    public class EntryKind
    {
        public int EntryKindId { get; set; }
        public string Description { get; set; }

        public int OwnerId { get; set; }
        public virtual EntryKind Owner { get; set; }
    }
}
