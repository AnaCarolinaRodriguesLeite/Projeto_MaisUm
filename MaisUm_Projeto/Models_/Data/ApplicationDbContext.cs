using System.Data.Entity;

namespace MaisUm_Projeto.Models_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<AtividadeFisica> AtividadesFisicas { get; set; }
        public DbSet<Alimentacao> Alimentacao { get; set; }
        public DbSet<Progresso> Progresso { get; set; }
    }
}
