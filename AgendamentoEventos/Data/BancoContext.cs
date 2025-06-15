using AgendamentoEventos.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoEventos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<EventoModel> Eventos { get; set; } = null!; // Inicialização explícita para evitar nullability warnings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configurações adicionais do modelo, se necessário
        }
    }
}
