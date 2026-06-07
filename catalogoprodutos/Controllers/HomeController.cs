using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace catalogoprodutos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Boletim()
        {
            List<string> disciplinas = new List<string>
            {
                "Matemática",
                "História",
                "Física",
                "Geografia",
                "Química"
            };

            List<double> notas = new List<double>
            {
                9.5,
                4.5,
                7.2,
                6.0,
                8.0
            };

            ViewBag.Disciplinas = disciplinas;
            ViewBag.Notas = notas;

            return View();
        }
    }
}