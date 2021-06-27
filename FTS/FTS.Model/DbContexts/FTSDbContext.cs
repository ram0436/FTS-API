using FTS.Configuration.Constant;
using FTS.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace FTS.Model.DbContexts
{
    public class FTSDbContext : DbContext
    {
        public FTSDbContext(DbContextOptions options) : base(options) { }
        public FTSDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ApplicationConstant.ConnectionString);
            }

        }
        //entities
        public DbSet<Users> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<ElectricAppliances> ElectricAppliances  { get; set; }
        public DbSet<Fashion> Fashion { get; set; }
        public DbSet<Furnitures> Furnitures  { get; set; }
        public DbSet<Gadgets> Gadgets { get; set; }
        public DbSet<Hobbies> Hobbies { get; set; }
        public DbSet<HouseApartments> HouseApartments { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<LandPlots> LandPlots { get; set; }
        public DbSet<OfficeShops> OfficeShops { get; set; }
        public DbSet<Pets> Pets { get; set; }
        public DbSet<PG> PG { get; set; }
        public DbSet<CommercialServices> CommercialServices { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
    }
}
