using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroupProject.Models;

namespace GroupProject.Data.UserDBContex
{
    public class cs : DbContext
    {
        public cs (DbContextOptions<cs> options)
            : base(options)
        {
        }

        public DbSet<GroupProject.Models.ItemsModel> ItemsModel { get; set; }

        public DbSet<GroupProject.Models.OrdersModel> OrdersModel { get; set; }
    }
}
