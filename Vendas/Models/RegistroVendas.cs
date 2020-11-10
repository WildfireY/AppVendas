﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models.Enums;

namespace Vendas.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Montante { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public RegistroVendas() { }

        public RegistroVendas(int id, DateTime data, double montante, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
