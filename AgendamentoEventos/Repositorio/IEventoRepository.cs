using AgendamentoEventos.Models;

namespace AgendamentoEventos.Repositorio
{
    public interface IEventoRepository
    {
        List<EventoModel> ObterTodosEventos();

        EventoModel Adicionar(EventoModel evento);
    }
}
