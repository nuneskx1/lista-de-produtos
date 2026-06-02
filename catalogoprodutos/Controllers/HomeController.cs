using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers 
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

    namespace boletimdenotas.Controllers
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
}