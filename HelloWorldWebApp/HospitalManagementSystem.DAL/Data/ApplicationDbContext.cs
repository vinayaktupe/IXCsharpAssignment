using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using HospitalManagementSystem.DAL.Data.Model;
using System;

namespace HospitalManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class UserDefinedDbContext : DbContext
    {

        public UserDefinedDbContext()
        {
        }

        public UserDefinedDbContext(DbContextOptions<UserDefinedDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().Property(u => u.IsActive).HasDefaultValue(true);
            modelBuilder.Entity<AppUser>().Property(u => u.CreatedAt).HasDefaultValue(DateTime.Now);
            
            //modelBuilder.Entity<AppUser>(entity=>

            //entity.HasOne(d => d.Doctor)
            //.WithMany(p=>)
            //   .HasForeignKey(d => d.)

            //   .HasConstraintName("FK_StudentInfoMaster_Student");
            //);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=vinayakt\\SQLEXPRESS;Database=HospitalManagementSystem;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        } 
    }
}
