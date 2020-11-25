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
    public class DepartmentSeed : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            List<Department> role =  new List<Department>
            {
                new Department() {ID = 1, Name = "Finance" },
                new Department() {ID = 2, Name = "Management"},
                new Department() {ID = 3, Name = "Sales"},
                new Department() {ID = 4, Name = "Transport"},
                new Department() {ID = 5, Name = "Labour"}

            };
            builder.HasData(role);
        }




    }
}