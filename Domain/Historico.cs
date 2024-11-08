namespace CHALLENGE.Domain
{
    public class Historico
    {
        public int? Id { get; set; }
        public required DateTime DataConsulta { get; set; }
        public required string Motivo { get; set; }
        public required string NomeMedico { get; set; }
        public required string Especialidade { get; set; }
        public int? PacienteId { get; set; }
        public required Paciente Paciente { get; set; }
    }
}