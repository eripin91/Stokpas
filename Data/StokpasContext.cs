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

        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Logistics> Logistics { get; set; }
        public DbSet<Products> Products{ get; set; }
        public DbSet<ShCategorys> ShCategorys { get; set; }
        public DbSet<ShProducts> ShProducts { get; set; }
        public DbSet<TierVariants> TierVariants { get; set; }
        public DbSet<TpCategorys> TpCategorys { get; set; }        
        public DbSet<TpProducts> TpProducts { get; set; }        
        public DbSet<VariantModel> VariantModels { get; set; }
        public DbSet<VariantOptions> VariantOptions { get; set; }
        public DbSet<Warehouses> Warehouses { get; set; }
        public DbSet<Wholesales> Wholesales { get; set; }
    }
}
