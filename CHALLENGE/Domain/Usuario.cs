namespace CHALLENGE.Domain
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string Nome { get; set; } 
        public string Sobrenome { get; set; } 
        public string Email { get; set; } 
        public string Senha { get; set; } 
        public DateTime DataNascimento { get; set; } 
        public string Sexo { get; set; } 
        public string TipoPlano { get; set; } 
        public string Cep { get; set; } 
    }
}