using Microsoft.EntityFrameworkCore;
using Stokpas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stokpas.Data
{
    public class StokpasContext : DbContext
    {
        public StokpasContext(DbContextOptions<StokpasContext> options)
            : base(options)
        {
        }

        public DbSet<Products> Product { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Logistics> Logistics { get; set; }
        public DbSet<Wholesales> Wholesales{ get; set; }
        public DbSet<TpCategorys> TpCategorys { get; set; }
        public DbSet<ShCategorys> ShCategorys { get; set; }
    }
}
