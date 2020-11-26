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
                new Place() {ID = 1, Name = "Helioplis 1" },
                new Place() {ID = 2, Name = "Heliopolis 2"},
                new Place() {ID = 3, Name = "Sabteya"},
                new Place() {ID = 4, Name = "Embaba"}

            };
            builder.HasData(role);
        }




    }
}