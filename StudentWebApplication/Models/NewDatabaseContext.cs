using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentWebApplication.Models
{
    public partial class NewDatabaseContext : DbContext
    {
        public NewDatabaseContext()
        {
        }

        public NewDatabaseContext(DbContextOptions<NewDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NewStudent> NewStudent { get; set; }

        // Unable to generate entity type for table 'dbo.Table_1'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=NewDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewStudent>(entity =>
            {
                entity.HasKey(e => e.Studentid);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Course)
                    .HasColumnName("course")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasColumnName("studentName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.University)
                    .HasColumnName("university")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
