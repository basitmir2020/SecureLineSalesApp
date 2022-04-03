using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SecureLineSalesApp.Models
{
    public partial class SalesDbContext : DbContext
    {
        public SalesDbContext()
        {
        }

        public SalesDbContext(DbContextOptions options): base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Price> Prices { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductVaration> ProductVarations { get; set; } = null!;
        public virtual DbSet<Stock> Stocks { get; set; } = null!;
        public virtual DbSet<SubCategory> SubCategories { get; set; } = null!;
        public virtual DbSet<SubSubCategory> SubSubCategories { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Varation> Varations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=BASITMIR\\SQLEXPRESS;Database=SalesDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("Price");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GrossPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProfitPercent).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Id_Id");

                entity.HasOne(d => d.Varation)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.VarationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVarationId_Id");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductVaration>(entity =>
            {
                entity.ToTable("ProductVaration");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVarations)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductId_Id");

                entity.HasOne(d => d.Varation)
                    .WithMany(p => p.ProductVarations)
                    .HasForeignKey(d => d.VarationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Varation_Id");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Id");

                entity.HasOne(d => d.Varation)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.VarationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVaration_Id");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.ToTable("SubCategory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Category_Id");
            });

            modelBuilder.Entity<SubSubCategory>(entity =>
            {
                entity.ToTable("SubSubCategory");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SubSubCategoryName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.SubSubCategories)
                    .HasForeignKey(d => d.SubCategoryId)
                    .HasConstraintName("FK_SubCategory_Id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Lname).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.Parentage).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Varation>(entity =>
            {
                entity.ToTable("Varation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.VariationName).HasMaxLength(100);

                entity.Property(e => e.VariationValue).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
