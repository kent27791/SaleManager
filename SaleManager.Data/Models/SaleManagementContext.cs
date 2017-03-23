using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SaleManager.Data.Models.Mapping;

namespace SaleManager.Data.Models
{
    public partial class SaleManagementContext : DbContext
    {
        static SaleManagementContext()
        {
            Database.SetInitializer<SaleManagementContext>(null);
        }

        public SaleManagementContext()
            : base("Name=SaleManagementContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryNote> DeliveryNotes { get; set; }
        public DbSet<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
        public DbSet<Produce> Produces { get; set; }
        public DbSet<ProduceDetail> ProduceDetails { get; set; }
        public DbSet<ProduceGroup> ProduceGroups { get; set; }
        public DbSet<ReceiptNote> ReceiptNotes { get; set; }
        public DbSet<ReceiptNoteDetail> ReceiptNoteDetails { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffGroup> StaffGroups { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DeliveryNoteMap());
            modelBuilder.Configurations.Add(new DeliveryNoteDetailMap());
            modelBuilder.Configurations.Add(new ProduceMap());
            modelBuilder.Configurations.Add(new ProduceDetailMap());
            modelBuilder.Configurations.Add(new ProduceGroupMap());
            modelBuilder.Configurations.Add(new ReceiptNoteMap());
            modelBuilder.Configurations.Add(new ReceiptNoteDetailMap());
            modelBuilder.Configurations.Add(new StaffMap());
            modelBuilder.Configurations.Add(new StaffGroupMap());
            modelBuilder.Configurations.Add(new StockMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new UnitMap());
        }
    }
}
