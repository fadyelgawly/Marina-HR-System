using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MarinaHR.Models;

namespace MarinaHR.Seeding
{
    public class RoleSeed : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            List<UserRole> role =  new List<UserRole>
            {
                new UserRole() {Id = "57784dee-54ff-4115-9835-da06239d6117", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
                new UserRole() {Id = "93c4a412-3af5-49f8-9b27-cecc7b6f6e79", Name = "Employee", NormalizedName = "EMPLOYEE" }
            };
            builder.HasData(role);
        }




    }
}