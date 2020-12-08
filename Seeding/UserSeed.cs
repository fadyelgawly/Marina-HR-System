using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MarinaHR.Models;

namespace MarinaHR.Seeding
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var admin = new User
            {
                Id = "6510262c-bbcb-4629-b1e7-20de05ef7ae6",
                PhoneNumber = "01111257052",
                UserName = "admin",
                Name = "عزيز حنا",
                NormalizedUserName = "ADMIN",
                Email = "azizmichael@aucegypt.edu",
                NormalizedEmail = "AZIZMICHAEL@AUCEGYPT.EDU",
                PhoneNumberConfirmed = true,
                LockoutEnabled = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                DepartmentID = 1,
                PlaceID = 14
            };

            admin.PasswordHash = PasswordGenerator(admin, "admin");
            builder.HasData(admin);

        }
        private string PasswordGenerator(User user, string password)
        {
            var passwordHash = new PasswordHasher<User>();
            return passwordHash.HashPassword(user, password);
        }
    }
}