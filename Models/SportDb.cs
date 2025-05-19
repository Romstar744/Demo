namespace Sport.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SportDb : DbContext
    {
        public SportDb()
            : base("name=SportDb")
        {
        }

        public virtual DbSet<CathegoryProduct> CathegoryProduct { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<PickUpPoint> PickUpPoint { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<StatusOrder> StatusOrder { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CathegoryProduct>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.CathegoryProduct)
                .HasForeignKey(e => e.CathegoryProductID);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Manufacturer)
                .HasForeignKey(e => e.ManufacturerID);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.OrderProduct)
                .WithOptional(e => e.Products)
                .HasForeignKey(e => e.ProductArticulNumberID);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithOptional(e => e.Role)
                .HasForeignKey(e => e.RoleID);

            modelBuilder.Entity<StatusOrder>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.StatusOrder)
                .HasForeignKey(e => e.StatusOrderID);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Supplier)
                .HasForeignKey(e => e.SupplierID);
        }
    }
}
