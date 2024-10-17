namespace CHALLENGE.Domain
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoPlano { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Cep { get; set; }
        
        public int CadastroId { get; set; }
        public Cadastro Cadastro { get; set; } 

        public List<Prontuario> Prontuarios { get; set; } = new List<Prontuario>();
        public List<Sinistro> Sinistros { get; set; } = new List<Sinistro>();
        public List<Historico> Historicos { get; set; } = new List<Historico>();

        public bool VerificarRisco()
        {
            return Sinistros.Count > 0 || Historicos.Count > 5;
        }
    }
}