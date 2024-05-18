using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Project_GGG.Models;

namespace Project_GGG
{
    public partial class ProjectGGGContext : DbContext
    {
        public ProjectGGGContext()
        {
        }

        public ProjectGGGContext
            (DbContextOptions<ProjectGGGContext> options) 
            :base(options) 
        {
            
        }
        public virtual DbSet<Pricing> Pricing { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("\"data\" \"source=178.89.186.221\",\"1434;initial\" \"catalog=;user\",\"id=maksut_user;password=;MultipleActiveResultSets=True;;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TestAppUser");

            modelBuilder.Entity<Pricing>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PathToImage)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
