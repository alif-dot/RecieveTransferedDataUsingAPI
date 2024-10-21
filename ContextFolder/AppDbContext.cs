using Microsoft.EntityFrameworkCore;

namespace IMSPOS_SDSIS.ContextFolder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleDetail> SaleDetail { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetail { get; set; }
        public DbSet<KOTOrderMaster> KOTOrderMaster { get; set; }
        public DbSet<KOTOrderDetail> KOTOrderDetail { get; set; }
        public DbSet<GoodsReceive> GoodsReceive { get; set; }
        public DbSet<GoodsReceiveDetail> GoodsReceiveDetail { get; set; }
    }
}
