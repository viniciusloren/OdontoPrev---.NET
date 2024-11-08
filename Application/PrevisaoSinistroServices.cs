using System.Collections.Generic;
using System.Threading.Tasks;
using CHALLENGE.Domain;

namespace CHALLENGE.Application
{
    public class PrevisaoSinistroService
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly ISinistroRepository _sinistroRepository;

        public PrevisaoSinistroService(IPacienteRepository pacienteRepository, ISinistroRepository sinistroRepository)
        {
            _pacienteRepository = pacienteRepository;
            _sinistroRepository = sinistroRepository;
        }

        public async Task PreverSinistrosAsync()
        {
            var pacientes = await _pacienteRepository.GetAllPacientesAsync();
            
            foreach (var paciente in pacientes)
            {
                if (paciente.VerificarRisco())
                {
                    var sinistro = new Sinistro
                    {
                        NomePaciente = paciente.Nome,
                        TipoConsulta = "Odontologia", 
                        TipoSinistro = "Potencial",
                        Custo = 5000, 
                        StatusSinistro = "Pendente",
                        PacienteId = 1
                    };

                    await _sinistroRepository.AddSinistroAsync(sinistro);

                    EnviarAlerta(paciente);
                }
            }
        }

        public void EnviarAlerta(Paciente paciente)
        {
            Console.WriteLine($"Alerta enviado para {paciente.Nome} - Risco de sinistro identificado.");
        }
    }
}