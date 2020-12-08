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
    public class PlaceSeed : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            List<Place> role =  new List<Place>
            {
                new Place() {ID = 1, Name = "مخزن الضغط"},
                new Place() {ID = 2, Name = "مخزن اللزق"},
                new Place() {ID = 3, Name = "مخزن البولى"},
                new Place() {ID = 4, Name = "مخزن الصندره"},
                new Place() {ID = 5, Name = "مخزن النواكل"},
                new Place() {ID = 6, Name = "مخزن المول "},
                new Place() {ID = 7, Name = "مخزن الجراج"},
                new Place() {ID = 8, Name = "مخزن المواسير"},
                new Place() {ID = 9, Name = "مخزن الحجاز"},
                new Place() {ID = 10, Name = "مخزن روض الفرج"},
                new Place() {ID = 11, Name = "مخزن محل مارينا جروب( متواجد بمحل مارينا جروب )"},
                new Place() {ID = 12, Name = "مخزن جسر السويس ( بدون موظفين)"},
                new Place() {ID = 13, Name = "مارينا بلاست" },
                new Place() {ID = 14, Name = "مول مارينا بلاس" },
                new Place() {ID = 15, Name = "محل الاخوه" },
                new Place() {ID = 16, Name = "محل مارينا جروب" },
                new Place() {ID = 17, Name = "محل مارينا التجمع" },
                new Place() {ID = 18, Name = "اكوامارينا" }
                };
            builder.HasData(role);
        }




    }
}