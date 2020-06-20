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

        public DbSet<ProductModel> Product { get; set; }
    }
}
