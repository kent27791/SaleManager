using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class DeliveryNoteMap : EntityTypeConfiguration<DeliveryNote>
    {
        public DeliveryNoteMap()
        {
            // Primary Key
            this.HasKey(t => t.DeliveryNoteId);

            // Properties
            this.Property(t => t.ComputedId)
                .HasMaxLength(7)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            // Table & Column Mappings
            this.ToTable("DeliveryNote");
            this.Property(t => t.DeliveryNoteId).HasColumnName("DeliveryNoteId");
            this.Property(t => t.ComputedId).HasColumnName("ComputedId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.StockId).HasColumnName("StockId");
            this.Property(t => t.StaffId).HasColumnName("StaffId");
            this.Property(t => t.Date).HasColumnName("Date");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.DeliveryNotes)
                .HasForeignKey(d => d.CustomerId);
            this.HasRequired(t => t.Staff)
                .WithMany(t => t.DeliveryNotes)
                .HasForeignKey(d => d.StaffId);
            this.HasRequired(t => t.Stock)
                .WithMany(t => t.DeliveryNotes)
                .HasForeignKey(d => d.StockId);

        }
    }
}
