using ejemplo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo.DataAccess
{
    public class ApiDbContext : DbContext //DbContext de EntityFrameworKCore
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();
            base.OnModelCreating(modelBuilder);
        }

        DbSet<Footballteam> foolbalteams { get; set; }

        DbSet<Customer> Customers { get; set; }

        DbSet<Product> Products { get; set; }

        DbSet<SaleDetail> SaleDetails { get; set; }

        DbSet<Sale> Sales { get; set; }

    }
}
