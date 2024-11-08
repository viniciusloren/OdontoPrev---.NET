namespace CHALLENGE.Domain
{
    public class Usuario
    {
        public int? Id { get; set;} 
        public required string Nome { get; set; } 
        public required string Sobrenome { get; set; } 
        public required string Email { get; set; } 
        public required string Senha { get; set; } 
        public required DateTime DataNascimento { get; set; } 
        public required string Sexo { get; set; } 
        public required string TipoPlano { get; set; } 
        public required string Cep { get; set; } 
    }
}