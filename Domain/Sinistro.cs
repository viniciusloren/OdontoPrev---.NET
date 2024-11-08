namespace CHALLENGE.Domain
{
    public class Sinistro
    {
        public int? Id { get; set;}
        public required string NomePaciente { get; set; }
        public required string TipoConsulta { get; set; }
        public required string TipoSinistro { get; set; }
        public required decimal Custo { get; set; }
        public required string StatusSinistro { get; set; }
        
        public int? PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}