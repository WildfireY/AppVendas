using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models;
using Vendas.Models.Enums;

namespace Vendas.Data
{
    public class SeedingService
    {
        private VendasContext context;
        public SeedingService(VendasContext context)
        {
            this.context = context;
        }
        public void Seed()
        {
            if (context.Departamento.Any() || context.Vendedor.Any() || context.RegistroVendas.Any())
            {
                return;
            }
            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Financeiro");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "Josefino", "josefinopinto@gmail.com", new DateTime(1996, 5, 3), 2600.0, d1);
            Vendedor v2 = new Vendedor(2, "Godofredo", "godo@gmail.com", new DateTime(1986, 7, 2), 4500.0, d3);
            Vendedor v3 = new Vendedor(3, "Thomas Turbando", "manturbandopinto@gmail.com", new DateTime(2000, 6, 10), 1000.0, d2);
            Vendedor v4 = new Vendedor(4, "Kukah Beludo", "kukahbeludo@gmail.com", new DateTime(1998, 10, 15), 3000.0, d4);
            Vendedor v5 = new Vendedor(5, "Jaison Mendes", "jajamendes@gmail.com", new DateTime(1975, 6, 18), 5000.0, d3);
            Vendedor v6 = new Vendedor(6, "Jacinto Leite", "jacintoleite@gmail.com", new DateTime(1990, 5, 9), 2800.0, d1);

            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2005, 5, 9), 8000.0, StatusVenda.Pago, v1);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2009, 10, 5), 25000.0, StatusVenda.Pendente, v2);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2005, 8, 20), 3650.0, StatusVenda.Cancelado, v3);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2005, 10, 10), 88000.0, StatusVenda.Pago, v4);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2005, 12, 15), 97800.0, StatusVenda.Pendente, v5);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2005, 5, 7), 76800, StatusVenda.Cancelado, v6);

            context.Departamento.AddRange(d1, d2, d3, d4);
            context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);
            context.RegistroVendas.AddRange(r1, r2, r3, r4, r5, r6);

            context.SaveChanges();
        }
    }
}
