using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Data;
using Vendas.Models;

namespace Vendas.Services
{
    public class VendedoresService
    {
        private readonly VendasContext context;
        public VendedoresService(VendasContext context)
        {
            this.context = context;
        }
        public List<Vendedor> FindAll()
        {
            return context.Vendedor.ToList();
        }
    }
}
