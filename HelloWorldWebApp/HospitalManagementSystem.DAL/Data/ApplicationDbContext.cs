using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using HospitalManagementSystem.DAL.Data.Model;
using System;
using Microsoft.Extensions.Configuration;

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
        private readonly IConfiguration configuration;

        public UserDefinedDbContext()
        {
        }

        public UserDefinedDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}
