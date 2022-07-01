using Microsoft.EntityFrameworkCore;
using ProductAppApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppApi.DataAccess
{
    public class ProductDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=true;");
        }

        public DbSet<Product> tbBarkodokut { get; set; }
    }
}
