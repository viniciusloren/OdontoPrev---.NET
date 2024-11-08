using System;
using System.ComponentModel.DataAnnotations;

namespace CHALLENGE.ViewModels

{
	public class ProntuarioViewModel
	{
		[Required(ErrorMessage = "O nome � obrigat�rio.")]
		public required string Nome { get; set; }

		[Required(ErrorMessage = "O tipo de plano � obrigat�rio.")]
		public required string TipoPlano { get; set; }

		[Required(ErrorMessage = "A descri��o � obrigat�ria.")]
		public required string Descricao { get; set; }

		[Required(ErrorMessage = "O status do prontu�rio � obrigat�rio.")]
		public required string StatusProntuario { get; set; }

		[Required(ErrorMessage = "O ID do paciente � obrigat�rio.")]
		public required int Id { get; set; }
	}
}