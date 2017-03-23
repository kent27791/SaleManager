using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class StaffMap : EntityTypeConfiguration<Staff>
    {
        public StaffMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffId);

            // Properties
            this.Property(t => t.ComputedId)
                .HasMaxLength(6)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            this.Property(t => t.Fullname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IdCard)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Staff");
            this.Property(t => t.StaffId).HasColumnName("StaffId");
            this.Property(t => t.ComputedId).HasColumnName("ComputedId");
            this.Property(t => t.StaffGroupId).HasColumnName("StaffGroupId");
            this.Property(t => t.Fullname).HasColumnName("Fullname");
            this.Property(t => t.IdCard).HasColumnName("IdCard");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.IsWorking).HasColumnName("IsWorking");

            // Relationships
            this.HasRequired(t => t.StaffGroup)
                .WithMany(t => t.Staffs)
                .HasForeignKey(d => d.StaffGroupId);

        }
    }
}
