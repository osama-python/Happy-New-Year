using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HappyNewYear_DAL.Models
{
    public partial class HappyNewYearDBContext : DbContext
    {
        public HappyNewYearDBContext()
        {
        }

        public HappyNewYearDBContext(DbContextOptions<HappyNewYearDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Detail> Detail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=HappyNewYearDB;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detail>(entity =>
            {
                entity.HasKey(e => e.YourName)
                    .HasName("PK__Detail__27D6E361A0AAC152");

                entity.Property(e => e.YourName)
                    .HasColumnName("yourName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
