using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class ProduceMap : EntityTypeConfiguration<Produce>
    {
        public ProduceMap()
        {
            // Primary Key
            this.HasKey(t => t.ProduceId);

            // Properties
            this.Property(t => t.ComputedId)
                .HasMaxLength(6)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Produce");
            this.Property(t => t.ProduceId).HasColumnName("ProduceId");
            this.Property(t => t.ComputedId).HasColumnName("ComputedId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.ProduceGroupId).HasColumnName("ProduceGroupId");

            // Relationships
            this.HasRequired(t => t.ProduceGroup)
                .WithMany(t => t.Produces)
                .HasForeignKey(d => d.ProduceGroupId);
            this.HasRequired(t => t.Unit)
                .WithMany(t => t.Produces)
                .HasForeignKey(d => d.UnitId);

        }
    }
}
