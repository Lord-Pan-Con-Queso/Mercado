using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mercado.core.Models;

namespace Mercado.UI.Data
{
    public class MercadoContext : DbContext
    {
        public MercadoContext (DbContextOptions<MercadoContext> options)
            : base(options)
        {
        }

        public DbSet<Mercado.core.Models.Producto>? Producto { get; set; }
    }
}
