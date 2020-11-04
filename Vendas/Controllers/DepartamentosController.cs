using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> departamentos = new List<Departamento>();
            departamentos.Add(new Departamento { Id = 1, Nome = "Human Resources" });
            departamentos.Add(new Departamento { Id = 2, Nome = "Information Tecnology" });

            return View(departamentos);
        }
    }
}
