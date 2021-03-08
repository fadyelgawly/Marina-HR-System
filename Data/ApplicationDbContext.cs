using System.Transactions;
using System;
using System.Collections.Generic;
using System.Text;
using MarinaHR.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MarinaHR.Seeding;

namespace MarinaHR.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DepartmentSeed());
            builder.ApplyConfiguration(new PlaceSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<SalaryTransaction> Transaction { get; set; }    
        public DbSet<MarinaHR.Models.User> User { get; set; }
        
    }
}
