using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCClient.Models;

namespace MVCClient.Data
{
    public class CartContext : DbContext
    {
        public CartContext (DbContextOptions<CartContext> options)
            : base(options)
        {
        }

        public DbSet<MVCClient.Models.Cart> Cart { get; set; }

        public DbSet<MVCClient.Models.Product> Product { get; set; }

        public DbSet<MVCClient.Models.Login> Login { get; set; }
    }
}
