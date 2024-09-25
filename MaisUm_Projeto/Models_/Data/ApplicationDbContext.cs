using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MaisUm_Projeto.Models_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<AtividadesFisica> AtividadesFisicas { get; set; }
        public DbSet<Alimentacao> Alimentacoes { get; set; }
        public DbSet<Progresso> Progresso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Remove convenções que adicionam automaticamente pluralização
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Definir o esquema padrão (se necessário)
            modelBuilder.HasDefaultSchema("dbo");

            // Configurações específicas para cada tabela
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios", "dbo");
            modelBuilder.Entity<AtividadesFisica>().ToTable("AtividadesFisicas", "dbo");
            modelBuilder.Entity<Alimentacao>().ToTable("Alimentacao", "dbo");
            modelBuilder.Entity<Progresso>().ToTable("Progresso", "dbo");

            base.OnModelCreating(modelBuilder);
        }
    }
}
