using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CHALLENGE.ViewModels
{
    public class CadastroViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O sobrenome deve ter no máximo 100 caracteres.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O e-mail deve ser um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 100 caracteres.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O sexo é obrigatório.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O tipo de plano é obrigatório.")]
        public string TipoPlano { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório.")]
        [StringLength(10, ErrorMessage = "O CEP deve ter no máximo 10 caracteres.")]
        public string Cep { get; set; }

        public ICollection<PacienteViewModel> Pacientes { get; set; } = new List<PacienteViewModel>();
    }
}