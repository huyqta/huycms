namespace datacms
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CmsContext : DbContext
    {
        public CmsContext()
            : base("name=CmsContext")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Balance> Balance { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Import> Import { get; set; }
        public virtual DbSet<ImportDetail> ImportDetail { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<SaleDetail> SaleDetail { get; set; }
        public virtual DbSet<Trademark> Trademark { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balance>()
                .Property(e => e.OpeningBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Balance>()
                .Property(e => e.InwardAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Balance>()
                .Property(e => e.OutwardAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Balance>()
                .Property(e => e.AdjustAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Balance>()
                .Property(e => e.ClosingBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ImportDetail>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ImportDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ImportDetail>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Price>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Price>()
                .Property(e => e.Price1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleDetail>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SaleDetail>()
                .Property(e => e.DiscountPrice)
                .HasPrecision(19, 4);
        }
    }
}
