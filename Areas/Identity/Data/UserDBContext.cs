using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupProject.Areas.Identity.Data;
using GroupProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GroupProject.Data
{
    public class UserDBContext : IdentityDbContext<AppliocationUser>
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }

        public DbSet<ItemsModel> ItemsModel { get; set; }
        public DbSet<OrdersModel> OrdersModel { get; set; }

        public DbSet<UsersModel> UserModel { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<UsersModel>().HasData(
                new UsersModel
                {
                    UserId = 1,
                    FirstName = "Admin", //Can change to artist name
                    LastName = "Artist",
                    Email = "admin@admin.com",
                    Password = "Admin1",
                    Phone  = "4025555555",
                    Address = "8800 O Street",
                    City = "Lincoln",
                    State = "NE",
                    Zip = "68504"

                }
                );


        }

    }
}
