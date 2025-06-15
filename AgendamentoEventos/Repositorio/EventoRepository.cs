using AgendamentoEventos.Data;
using AgendamentoEventos.Models;

namespace AgendamentoEventos.Repositorio
{
    public class EventoRepository : IEventoRepository
    {
        private readonly BancoContext _bancoContext;
        public EventoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<EventoModel> ObterTodosEventos()
        {
            return _bancoContext.Eventos.ToList();
        }

        public EventoModel Adicionar(EventoModel evento)
        {
            _bancoContext.Eventos.Add(evento);
            _bancoContext.SaveChanges();
            return evento;
        }
    }
}
