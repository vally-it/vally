
using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Entry
    {
        public int EntryId { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public char Type { get; set; }
        public DateTime Date { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        public int EntryKindId { get; set; }
        public virtual EntryKind EntryKind { get; set; }


    }
}
