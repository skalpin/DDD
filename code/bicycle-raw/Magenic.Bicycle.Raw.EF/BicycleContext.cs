using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

#nullable disable

namespace Magenic.Bicycle.Raw.EF
{
    public partial class BicycleContext : DbContext
    {
        #region "Properties"
        public string ConnectionString { get; set; }
        public ILoggerFactory LoggrFactory { get; set; }
        #endregion

        #region "CTOR"

        private BicycleContext()
        {
        }

        private BicycleContext(DbContextOptions<BicycleContext> options)
            : base(options)
        {
        }

        public BicycleContext(ILoggerFactory loggerFactory, string connectionString)
        {
            this.LoggrFactory = loggerFactory;
            this.ConnectionString = connectionString;
        }

        public BicycleContext(ILoggerFactory loggerFactory, string connectionString, DbContextOptions<BicycleContext> options) : base(options)
        {
            this.LoggrFactory = loggerFactory;
            this.ConnectionString = connectionString;
        }

        #endregion

        #region "DbSets aka Tables"

        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<FilesToImport> FilesToImports { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrdersRaw> OrdersRaws { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        #endregion

        #region ""

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (string.IsNullOrWhiteSpace(this.ConnectionString)) throw new InvalidOperationException("Connection String is Required using the PROPERTY or CTOR");

                optionsBuilder
                    .UseLoggerFactory(this.LoggrFactory)
                    .UseSqlServer(this.ConnectionString, o =>
                    {
                        o.CommandTimeout((int)TimeSpan.FromSeconds(60).TotalSeconds);
                        o.EnableRetryOnFailure(
                            maxRetryCount: 3,
                            maxRetryDelay: TimeSpan.FromSeconds(15),
                            errorNumbersToAdd: null
                        );
                    })
                    .ConfigureWarnings(warnings => warnings.Default(WarningBehavior.Log));
                    ;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilesToImport>(entity =>
            {
                entity.Property(e => e.FileNamePath).IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Customer");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Price).HasDefaultValueSql("((20.00))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        #endregion
    }
}
