using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RentCarHub1.Models
{
    public partial class RentCarContext : DbContext
    {
        public RentCarContext()
        {
        }

        public RentCarContext(DbContextOptions<RentCarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carreg> Carregs { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Rentail> Rentails { get; set; }
        public virtual DbSet<Returncar> Returncars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localDb)\\MSSQLLocalDB;Initial Catalog=RentCar;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Carreg>(entity =>
            {
                entity.ToTable("carreg");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Available)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("available");

                entity.Property(e => e.Carno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("carno");

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("make");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Cutname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cutname");

                entity.Property(e => e.Mobile).HasColumnName("mobile");
            });

            modelBuilder.Entity<Rentail>(entity =>
            {
                entity.ToTable("rentail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Carid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("carid");

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Edate)
                    .HasColumnType("date")
                    .HasColumnName("edate");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.Sdate)
                    .HasColumnType("date")
                    .HasColumnName("sdate");
            });

            modelBuilder.Entity<Returncar>(entity =>
            {
                entity.ToTable("returncar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Carno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("carno");

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Elsp).HasColumnName("elsp");

                entity.Property(e => e.Fine).HasColumnName("fine");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
