using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SaleManager.Data.Models.Mapping
{
    public class StaffGroupMap : EntityTypeConfiguration<StaffGroup>
    {
        public StaffGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffGroupId);

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
            this.ToTable("StaffGroup");
            this.Property(t => t.StaffGroupId).HasColumnName("StaffGroupId");
            this.Property(t => t.ComputedId).HasColumnName("ComputedId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
