using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class ReceiptNoteMap : EntityTypeConfiguration<ReceiptNote>
    {
        public ReceiptNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.ReceiptNoteId);

            // Properties
            this.Property(t => t.ComputedId)
                .HasMaxLength(10)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            // Table & Column Mappings
            this.ToTable("ReceiptNote");
            this.Property(t => t.ReceiptNoteId).HasColumnName("ReceiptNoteId");
            this.Property(t => t.ComputedId).HasColumnName("ComputedId");
            this.Property(t => t.SupplierId).HasColumnName("SupplierId");
            this.Property(t => t.StockId).HasColumnName("StockId");
            this.Property(t => t.StaffId).HasColumnName("StaffId");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.Staff)
                .WithMany(t => t.ReceiptNotes)
                .HasForeignKey(d => d.StaffId);
            this.HasRequired(t => t.Stock)
                .WithMany(t => t.ReceiptNotes)
                .HasForeignKey(d => d.StockId);
            this.HasRequired(t => t.Supplier)
                .WithMany(t => t.ReceiptNotes)
                .HasForeignKey(d => d.SupplierId);

        }
    }
}
