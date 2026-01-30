using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyMAUIApp.Api
{
    public class CarListDbContext : IdentityDbContext //IdentityDbContext<IdentityUser, IdentityRole, string>//DbContext
    {
        public CarListDbContext(DbContextOptions<CarListDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars => Set<Car>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ---------- CAR SEED ----------
            modelBuilder.Entity<Car>().ToTable("Cars").HasData(
                new Car { Id = 1, Make = "Honda", Model = "Fit", Vin = "123" },
                new Car { Id = 2, Make = "Toyota", Model = "Prado", Vin = "456" },
                new Car { Id = 3, Make = "Honda", Model = "Civic", Vin = "789" },
                new Car { Id = 4, Make = "Audi", Model = "A5", Vin = "111" },
                new Car { Id = 5, Make = "BMW", Model = "M3", Vin = "222" }
            );

            // // ---------- ROLES ----------
            var adminRoleId = "hiuwerhg7yjb78";
            var userRoleId = "hiuwerhg7yjb72";


            modelBuilder.Entity<IdentityRole>().ToTable("IdentityRoles").HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = "00000000-0000-0000-0000-000000000001"
                },
                new IdentityRole
                {
                    Id = userRoleId,
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "00000000-0000-0000-0000-000000000002"
                }
            );

            //// ---------- USERS ----------
            //var hasher = new PasswordHasher<IdentityUser>();

            var adminUser = new IdentityUser
            {
                Id = "da3b3133-056a-4c3a-99a5-29ad9925934a",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                PasswordHash = "AQAAAAIAAYagAAAAEMOCKED_ADMIN_HASH",
                SecurityStamp = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
                ConcurrencyStamp = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
                EmailConfirmed = true
            };
            // adminUser.PasswordHash = hasher.HashPassword(adminUser, "P@ssword1");

            var normalUser = new IdentityUser
            {
                Id = "ea293138-f814-4d80-98f7-edba139c719f",
                UserName = "user@localhost.com",
                NormalizedUserName = "USER@LOCALHOST.COM",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                PasswordHash = "AQAAAAIAAYagAAAAEMOCKED_USER_HASH",
                SecurityStamp = "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb",
                ConcurrencyStamp = "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb",
                EmailConfirmed = true
            };
            //normalUser.PasswordHash = hasher.HashPassword(normalUser, "P@ssword1");
            modelBuilder.Entity<IdentityUser>().ToTable("IdentityUsers").HasData(adminUser, normalUser);

            // ---------- USER ROLES ----------
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("IdentityUserRoles").HasData(
                new IdentityUserRole<string>
                {
                    UserId = adminUser.Id,
                    RoleId = adminRoleId
                },
                new IdentityUserRole<string>
                {
                    UserId = normalUser.Id,
                    RoleId = userRoleId
                }
            );
        }
    }
}
