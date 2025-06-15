using AgendamentoEventos.Models;
using AgendamentoEventos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentoEventos.Controllers
{
    public class ControleDeEventos : Controller
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ControleDeEventos(IEventoRepository eventoRepository, IWebHostEnvironment webHostEnvironment)
        {
            _eventoRepository = eventoRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var eventos = _eventoRepository.ObterTodosEventos();
            return View(eventos);
        }

        [HttpGet]
        public IActionResult ComprarAgora()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VerEvento()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastrarEventos()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CadastrarEvento(EventoModel evento, IFormFile imagemEvento)
        {
            if (imagemEvento != null && imagemEvento.Length > 0)
            {
                using var ms = new MemoryStream();
                await imagemEvento.CopyToAsync(ms);
                evento.ImagemBytes = ms.ToArray();
            }

            // Limpa máscara do telefone - mantém só números
            if (!string.IsNullOrEmpty(evento.Telefone))
            {
                evento.Telefone = new string(evento.Telefone.Where(char.IsDigit).ToArray());
            }

            // Converte Preço (que vem formatado, ex: "R$ 50,00") para decimal
            if (!string.IsNullOrEmpty(Request.Form["preco"]))
            {
                var precoStr = Request.Form["preco"].ToString();

                // Remove tudo que não é número ou vírgula
                precoStr = new string(precoStr.Where(c => char.IsDigit(c) || c == ',' || c == '.').ToArray());

                // Ajusta vírgula para ponto, para parse decimal (cultura pt-BR usa vírgula)
                precoStr = precoStr.Replace(".", "").Replace(',', '.');

                if (decimal.TryParse(precoStr, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out decimal precoDecimal))
                {
                    evento.Preco = precoDecimal;
                }
            }

            _eventoRepository.Adicionar(evento);
            return RedirectToAction("Index");
        }


    }
}

