using Microsoft.AspNetCore.Mvc;

namespace AgendamentoEventos.Controllers
{
    public class CadastroEventos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
