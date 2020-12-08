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
                new Department() {ID = 1, Name = "ادارات شركه مارينا" },
                new Department() {ID = 2, Name = "اداره العملاء"},
                new Department() {ID = 3, Name = "الاداره الماليه"},
                new Department() {ID = 4, Name = "اداره الموردين"},
                new Department() {ID = 5, Name = "اداره السبتيه "},
                new Department() {ID = 6, Name = "اداره المخازن"},
                new Department() {ID = 7, Name = "اداره البرنامج"},
                new Department() {ID = 8, Name = "اداره الفيوم"},
                new Department() {ID = 9, Name = "اداره شئون الافراد"}
            };
            builder.HasData(role);
        }




    }
}