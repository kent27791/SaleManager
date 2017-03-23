using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class ReceiptNoteDetailMap : EntityTypeConfiguration<ReceiptNoteDetail>
    {
        public ReceiptNoteDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ReceiptNoteId, t.ProduceId });

            // Properties
            this.Property(t => t.ReceiptNoteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProduceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ReceiptNoteDetails");
            this.Property(t => t.ReceiptNoteId).HasColumnName("ReceiptNoteId");
            this.Property(t => t.ProduceId).HasColumnName("ProduceId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");

            // Relationships
            this.HasRequired(t => t.Produce)
                .WithMany(t => t.ReceiptNoteDetails)
                .HasForeignKey(d => d.ProduceId);
            this.HasRequired(t => t.ReceiptNote)
                .WithMany(t => t.ReceiptNoteDetails)
                .HasForeignKey(d => d.ReceiptNoteId);

        }
    }
}
