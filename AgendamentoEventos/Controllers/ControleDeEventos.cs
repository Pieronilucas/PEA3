using Microsoft.AspNetCore.Mvc;

namespace AgendamentoEventos.Controllers
{
    public class ControleDeEventos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ComprarAgora()
        {
            return View();
        }

        public IActionResult VerEvento()
        {
            return View();
        }

        public IActionResult CadastrarEventos()
        {
            return View();
        }

    }
}
