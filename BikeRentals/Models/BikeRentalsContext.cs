using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BikeRentals.models
{
    public partial class BikeRentalsContext : DbContext
    {
        public BikeRentalsContext()
        {
        }

        public BikeRentalsContext(DbContextOptions<BikeRentalsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bike> Bikes { get; set; }
        public virtual DbSet<BikeSize> BikeSizes { get; set; }
        public virtual DbSet<BikeStat> BikeStats { get; set; }
        public virtual DbSet<BikeStatus> BikeStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ASUS-G0T14;Initial Catalog=BikeRentals;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bike>(entity =>
            {
                entity.ToTable("Bike");

                entity.Property(e => e.BikeSize)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BikeStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BikeSizeNavigation)
                    .WithMany(p => p.Bikes)
                    .HasForeignKey(d => d.BikeSize)
                    .HasConstraintName("FK__Bike__BikeSize__3D5E1FD2");

                entity.HasOne(d => d.BikeStatusNavigation)
                    .WithMany(p => p.Bikes)
                    .HasForeignKey(d => d.BikeStatus)
                    .HasConstraintName("FK__Bike__BikeStatus__3C69FB99");
            });

            modelBuilder.Entity<BikeSize>(entity =>
            {
                entity.HasKey(e => e.BikeSize1)
                    .HasName("PK__BikeSize__19DFD617D0D80220");

                entity.ToTable("BikeSize");

                entity.Property(e => e.BikeSize1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BikeSize");
            });

            modelBuilder.Entity<BikeStat>(entity =>
            {
                entity.HasKey(e => e.BikeStatus)
                    .HasName("PK__BikeStat__640734D84155132A");

                entity.Property(e => e.BikeStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BikeStatus>(entity =>
            {
                entity.HasKey(e => e.BikeStats)
                    .HasName("PK__BikeStat__47060FB7F92FBF92");

                entity.ToTable("BikeStatus");

                entity.Property(e => e.BikeStats)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bike>().HasData(
                new Bike { BikeId = 10, BikeStatus = "Available", BikeSize = "Medium" });



            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
