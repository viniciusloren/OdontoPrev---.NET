namespace CHALLENGE.ViewModels
{
    public class PacienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoPlano { get; set; }
        public string Sexo { get; set; }
        public string Cep { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public int CadastroId { get; set; } 

        public int Idade
        {
            get
            {
                return DateTime.Now.Year - DataNascimento.Year - (DateTime.Now.DayOfYear < DataNascimento.DayOfYear ? 1 : 0);
            }
        }

        public bool PossuiRisco { get; set; }

        public int NumeroDeSinistros { get; set; }

        public int NumeroDeHistoricos { get; set; }
    }
}
