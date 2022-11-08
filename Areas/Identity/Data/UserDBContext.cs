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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
