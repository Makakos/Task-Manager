using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Manager.Services;
using Task_Manager.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace Task_Manager.Models
{
    public class ApplicationContext:IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }

        public void Configure(EntityTypeBuilder<Goal> builder)
        {
              builder.HasOne(x => x.User).WithMany(y => y.Goals).HasForeignKey(z => z.UserId);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "User",
                NormalizedName = "USER"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "Makakos",
                NormalizedUserName = "MAKAKOS",
                Email = "maximgaber65@gmail.com",
                NormalizedEmail = "MAXIMGABER65@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "qwerty1337"),
                PhoneNumber="+380974675806",
                SecurityStamp = string.Empty
            });


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

           
        }

    }
}
