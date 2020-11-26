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
                Email = "azizmichael@aucegypt.edu",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
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