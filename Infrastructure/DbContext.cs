using CHALLENGE.Domain;
using Microsoft.EntityFrameworkCore;

namespace CHALLENGE.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Sinistro> Sinistros { get; set; }
        public DbSet<Cadastro> Cadastros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>()
                .HasMany(p => p.Prontuarios)
                .WithOne()
                .HasForeignKey(pr => pr.PacienteId);

            modelBuilder.Entity<Paciente>()
                .HasMany(p => p.Sinistros)
                .WithOne()
                .HasForeignKey(s => s.PacienteId);

            modelBuilder.Entity<Paciente>()
                .HasMany(p => p.Historicos)
                .WithOne()
                .HasForeignKey(h => h.PacienteId);

            modelBuilder.Entity<Cadastro>()
                .HasMany(c => c.Pacientes)
                .WithOne()
                .HasForeignKey(p => p.CadastroId);
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuarios");

            base.OnModelCreating(modelBuilder);
        }
    }
}