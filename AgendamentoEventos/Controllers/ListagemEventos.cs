using Microsoft.AspNetCore.Mvc;

namespace AgendamentoEventos.Controllers
{
    public class ListagemEventos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
