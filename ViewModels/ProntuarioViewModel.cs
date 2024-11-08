using System;
using System.ComponentModel.DataAnnotations;

namespace CHALLENGE.ViewModels

{
	public class ProntuarioViewModel
	{
		[Required(ErrorMessage = "O nome é obrigatório.")]
		public required string Nome { get; set; }

		[Required(ErrorMessage = "O tipo de plano é obrigatório.")]
		public required string TipoPlano { get; set; }

		[Required(ErrorMessage = "A descrição é obrigatória.")]
		public required string Descricao { get; set; }

		[Required(ErrorMessage = "O status do prontuário é obrigatório.")]
		public required string StatusProntuario { get; set; }

		[Required(ErrorMessage = "O ID do paciente é obrigatório.")]
		public required int Id { get; set; }
	}
}