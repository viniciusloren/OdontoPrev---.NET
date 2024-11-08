namespace CHALLENGE.Domain
{
    public class Prontuario
    {
        public int? Id { get; set; }
        public required string Nome { get; set; }
        public required string TipoPlano { get; set; }
        public required string Descricao { get; set; }
        public required string StatusProntuario { get; set; }
        
        public int? PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}