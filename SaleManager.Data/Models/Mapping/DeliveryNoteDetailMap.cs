using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class DeliveryNoteDetailMap : EntityTypeConfiguration<DeliveryNoteDetail>
    {
        public DeliveryNoteDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DeliveryNoteId, t.ProduceId });

            // Properties
            this.Property(t => t.DeliveryNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProduceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DeliveryNoteDetails");
            this.Property(t => t.DeliveryNoteId).HasColumnName("DeliveryNoteId");
            this.Property(t => t.ProduceId).HasColumnName("ProduceId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.DeliveryNote)
                .WithMany(t => t.DeliveryNoteDetails)
                .HasForeignKey(d => d.DeliveryNoteId);
            this.HasRequired(t => t.Produce)
                .WithMany(t => t.DeliveryNoteDetails)
                .HasForeignKey(d => d.ProduceId);

        }
    }
}
