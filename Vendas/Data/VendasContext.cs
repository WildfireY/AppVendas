using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vendas.Models;

namespace Vendas.Data
{
    public class VendasContext : DbContext
    {
        public VendasContext (DbContextOptions<VendasContext> options)
            : base(options)
        {
        }

        public DbSet<Vendas.Models.Departamento> Departamento { get; set; }
    }
}
