
using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public decimal CurrentBalance { get; set; }
        public DateTime RegisterDate { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int AccountKindId { get; set; }
        public virtual AccountKind AccoundKind { get; set; }
    }
}
