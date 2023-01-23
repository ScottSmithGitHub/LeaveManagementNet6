using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            //var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "0c2a5081-39f8-4a14-a950-4086b43f2fb6",
                    UserId = "a1924f34-01ea-4e44-b006-21fe720c30b7"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "9351206b-47e3-425d-9ba7-b3c544d88d59",
                    UserId = "a8f8b6f5-1b91-449f-b946-c0c07417a2fa"
                }
            );
        }
    }
}
