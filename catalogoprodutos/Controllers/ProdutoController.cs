using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace catalogoprodutos.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>
            {
                "Notebook Pro",
                "Mouse Sem Fio",
                "Teclado Mecânico",
                "Cabo HDMI",
                "Monitor UltraWide"
            };

            List<double> precos = new List<double>
            {
                4500.00,
                89.90,
                250.00,
                45.50,
                1200.00
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}
