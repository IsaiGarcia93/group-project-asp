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
    public class UserDBContext : IdentityDbContext<ApplicationUser>
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }

        public DbSet<ItemsModel> Items { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<UsersModel> UserModel { get; set; }
        public DbSet<OrderDetails> OrdersDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


           

            builder.Entity<OrderDetails>().HasKey(od => new { od.OrderID, od.ItemID });
            builder.Entity<OrderDetails>().HasOne(od => od.Item).WithMany(o => o.OrderDetails).HasForeignKey(od => od.ItemID);
            builder.Entity<OrderDetails>().HasOne(od => od.Order).WithMany(d => d.OrderDetails).HasForeignKey(bc => bc.OrderID);
        }

    }
}
