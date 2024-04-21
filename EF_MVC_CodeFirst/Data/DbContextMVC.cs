using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_MVC_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;


namespace EF_MVC_CodeFirst.Data
{
    public class DbContextMVC : DbContext
    {
        public DbContextMVC(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Sinhvien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Khoa> Khoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lop>()
                .HasOne(l => l.Khoa)
                .WithMany(k => k.Lops)
                .HasForeignKey(l => l.KhoaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Sinhvien>()
                .HasOne(s => s.Lop)
                .WithMany(l => l.SinhViens)
                .HasForeignKey(s => s.LopId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
