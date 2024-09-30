namespace CHALLENGE.Domain
{
    public class Prontuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoPlano { get; set; }
        public string Descricao { get; set; }
        public string StatusProntuario { get; set; }
        
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}