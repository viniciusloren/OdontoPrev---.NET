namespace CHALLENGE.Domain
{
    public class Historico
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Motivo { get; set; }
        public string NomeMedico { get; set; }
        public string Especialidade { get; set; }
        
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}