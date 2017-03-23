using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class ProduceGroupMap : EntityTypeConfiguration<ProduceGroup>
    {
        public ProduceGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ProduceGroupId);

            // Properties
            this.Property(t => t.ComputedId)
                .HasMaxLength(7)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProduceGroup");
            this.Property(t => t.ProduceGroupId).HasColumnName("ProduceGroupId");
            this.Property(t => t.ComputedId).HasColumnName("ComputedId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
