using System;
using System.ComponentModel.DataAnnotations;

namespace CHALLENGE.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome � obrigat�rio.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no m�ximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome � obrigat�rio.")]
        [StringLength(100, ErrorMessage = "O sobrenome deve ter no m�ximo 100 caracteres.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O e-mail � obrigat�rio.")]
        [EmailAddress(ErrorMessage = "O e-mail deve ser um endere�o de e-mail v�lido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha � obrigat�ria.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 100 caracteres.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "A data de nascimento � obrigat�ria.")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O sexo � obrigat�rio.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O tipo de plano � obrigat�rio.")]
        public string TipoPlano { get; set; }

        [Required(ErrorMessage = "O CEP � obrigat�rio.")]
        [StringLength(10, ErrorMessage = "O CEP deve ter no m�ximo 10 caracteres.")]
        public string Cep { get; set; }
    }
}