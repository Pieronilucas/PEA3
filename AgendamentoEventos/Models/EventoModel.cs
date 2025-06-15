using System.ComponentModel.DataAnnotations;

namespace AgendamentoEventos.Models
{
    public class EventoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Artista { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Preco { get; set; }

        // Novo campo binário
        public byte[]? ImagemBytes { get; set; }
    }

}
