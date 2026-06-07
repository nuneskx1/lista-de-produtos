using Microsoft.AspNetCore.Mvc;
using catalogoprodutos.Models;

namespace catalogoprodutos.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                TempData["MensagemSucesso"] = "Aluno cadastrado com sucesso!";
                return RedirectToAction("Cadastrar");
            }
            return View(aluno);
        }
    }
}