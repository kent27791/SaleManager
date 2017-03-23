using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class ProduceDetailMap : EntityTypeConfiguration<ProduceDetail>
    {
        public ProduceDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProduceId, t.Date });

            // Properties
            this.Property(t => t.ProduceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProduceDetails");
            this.Property(t => t.ProduceId).HasColumnName("ProduceId");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.OpeningStock).HasColumnName("OpeningStock");
            this.Property(t => t.ClosingStock).HasColumnName("ClosingStock");
            this.Property(t => t.InputStock).HasColumnName("InputStock");
            this.Property(t => t.OutputStock).HasColumnName("OutputStock");

            // Relationships
            this.HasRequired(t => t.Produce)
                .WithMany(t => t.ProduceDetails)
                .HasForeignKey(d => d.ProduceId);

        }
    }
}
