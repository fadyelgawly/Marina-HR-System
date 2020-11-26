using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarinaHR.Seeding
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            IdentityUserRole<string> usersToRole = new IdentityUserRole<string>
            {
                RoleId = "57784dee-54ff-4115-9835-da06239d6117", UserId = "6510262c-bbcb-4629-b1e7-20de05ef7ae6"
            };

            builder.HasData(usersToRole);
        }
    }
}