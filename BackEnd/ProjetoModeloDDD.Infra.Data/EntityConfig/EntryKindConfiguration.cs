using System.Data.Entity.ModelConfiguration;
using ProjectVally.Domain.Entities;

namespace ProjectVally.Infra.Data.EntityConfig
{
    public class EntryKindConfiguration : EntityTypeConfiguration<EntryKind>
    {
        public EntryKindConfiguration()
        {
            HasKey(e => e.EntryKindId);

            Property(e => e.Description)
                .IsRequired();

            HasRequired(e => e.Owner)
                .WithMany()
                .HasForeignKey(e => e.OwnerId);

        }
    }
}
