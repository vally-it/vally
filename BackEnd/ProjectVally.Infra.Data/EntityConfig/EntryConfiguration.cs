using System.Data.Entity.ModelConfiguration;
using ProjectVally.Domain.Entities;

namespace ProjectVally.Infra.Data.EntityConfig
{
    public class EntryConfiguration : EntityTypeConfiguration<Entry>
    {
        public EntryConfiguration()
        {
            HasKey(e => e.EntryId);

            Property(e => e.Description)
                .IsRequired();

            Property(e => e.Value)
                .IsRequired();

            Property(e => e.Date)
                .IsRequired();

            HasRequired(e => e.Account)
                .WithMany()
                .HasForeignKey(e => e.AccountId);

            HasRequired(e => e.EntryKind)
                .WithMany()
                .HasForeignKey(e => e.EntryKindId);

        }
    }
}
