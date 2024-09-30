namespace CHALLENGE.Domain
{
    public class Sinistro
    {
        public int Id { get; set; }
        public string NomePaciente { get; set; }
        public string TipoConsulta { get; set; }
        public string TipoSinistro { get; set; }
        public decimal Custo { get; set; }
        public string StatusSinistro { get; set; }
        
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}