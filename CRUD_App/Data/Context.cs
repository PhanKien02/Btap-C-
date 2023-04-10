using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_App.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUD_App.Data
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<TaiLieu> Students { get; set; }
        public DbSet<NguoiDung> Enrollments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiLieu>().ToTable("TaiLieu");
            modelBuilder.Entity<NguoiDung>().ToTable("NguoiDung");
        }
    }
}
