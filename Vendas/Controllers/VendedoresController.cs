using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vendas.Services;

namespace Vendas.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedoresService vendedoresService;
        public VendedoresController(VendedoresService vendedoresService)
        {
            this.vendedoresService = vendedoresService;
        }
        public IActionResult Index()
        {
            var list = vendedoresService.FindAll();
            return View(list);
        }
    }
}
