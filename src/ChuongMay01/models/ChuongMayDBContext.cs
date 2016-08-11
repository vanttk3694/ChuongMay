using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChuongMay01.models
{
    public partial class ChuongMayDBContext : DbContext
    {
        public ChuongMayDBContext(DbContextOptions<ChuongMayDBContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName).IsRequired();

                entity.Property(e => e.CategoryUrl).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerAddress).IsRequired();

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.CustomerFacebookId).HasColumnType("varchar(max)");

                entity.Property(e => e.CustomerGoogleId).HasColumnType("varchar(max)");

                entity.Property(e => e.CustomerName).IsRequired();

                entity.Property(e => e.CustomerPassword)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasColumnType("varchar(12)")
                    .HasDefaultValueSql("'n/a'");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.FeedbackContent).IsRequired();

                entity.Property(e => e.FeedbackName).IsRequired();

                entity.Property(e => e.FeedbackStatus).HasDefaultValueSql("0");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_FeedbackManager");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.Property(e => e.ManagerEmail)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ManagerName).IsRequired();

                entity.Property(e => e.ManagerPassword)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.ManagerPermission)
                    .IsRequired()
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.ManagerUsername)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsContent).IsRequired();

                entity.Property(e => e.NewsUrl)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_NewsManager");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.PhotoUrl)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_PhotoNews");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PhotoProduct");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductInfo).IsRequired();

                entity.Property(e => e.ProductName).IsRequired();

                entity.Property(e => e.ProductUrl).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductCategory");
            });
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Product> Product { get; set; }
    }
}