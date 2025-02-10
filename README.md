Este é um sistema de gestão desenvolvido com ASP.NET Core para cadastro de usuários, pacientes e prontuários. A aplicação utiliza a arquitetura MVC (Model-View-Controller) para organizar e estruturar o código de maneira eficiente.

## VINICIUS LORENZETTI RM:553121
## JOAO PEDRO FONTANA RM:553343
## Funcionalidades

1. **Cadastro de Usuário**
   - Permite que o administrador registre novos usuários no sistema.
   - Campos: Nome, Sobrenome, Email, Senha, Data de Nascimento, Sexo, Tipo de Plano, CEP.

2. **Cadastro de Paciente**
   - Cadastro de novos pacientes com informações como Nome, Idade e Email.

3. **Cadastro de Prontuário**
   - Criação de prontuários médicos para os pacientes, com campos como Nome, Tipo de Plano, Descrição, Status do Prontuário, ID do Paciente.

4. **Exibição de Detalhes**
   - Exibe os detalhes de usuários, pacientes e prontuários registrados.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework principal para desenvolvimento web.
- **Bootstrap**: Framework CSS para garantir um design responsivo.
- **MVC (Model-View-Controller)**: Arquitetura utilizada para organizar a aplicação.
- **HTML5**: Marcação semântica para a interface do usuário.
- **CSS**: Estilização da interface.

## Estrutura do Projeto

O projeto está estruturado conforme o padrão MVC (Model-View-Controller):

- **Model**: Contém as classes de dados e regras de negócios (ViewModels).
- **View**: Contém os arquivos de interface do usuário (HTML, Razor).
- **Controller**: Lógica de controle para a interação entre o modelo e a visualização.

## Endpoints da API

### 2. Cadastro de Paciente

- **Endpoint**: `/Paciente/CadastrarPaciente`
- **Método HTTP**: `POST`
- **Descrição**: Este endpoint permite o cadastro de novos pacientes.
- **Campos esperados no corpo da requisição**:
  - `Nome`: Nome do paciente.
  - `Idade`: Idade do paciente.
  - `Email`: Email do paciente.

- **Exemplo de requisição**:
  ```json
  {
    "Nome": "Maria Oliveira",
    "Idade": 30,
    "Email": "maria.oliveira@email.com"
  }
3. Cadastro de Prontuário
Endpoint: /Prontuario/CadastrarProntuario

Método HTTP: POST

Descrição: Este endpoint cria um prontuário médico para um paciente.

Campos esperados no corpo da requisição:

Nome: Nome do prontuário.
TipoPlano: Tipo de plano de saúde relacionado ao prontuário.
Descricao: Descrição do prontuário.
StatusProntuario: Status atual do prontuário (exemplo: "Ativo", "Concluído").
PacienteId: ID do paciente ao qual o prontuário pertence.
Exemplo de requisição:

json
Copiar código
{
  "Nome": "Prontuário de Maria Oliveira",
  "TipoPlano": "Premium",
  "Descricao": "Consulta de rotina",
  "StatusProntuario": "Ativo",
  "PacienteId": 1
}
4. Exibição de Detalhes do Usuário
Endpoint: /Usuario/DetalhesUsuario/{id}

Método HTTP: GET

Descrição: Este endpoint retorna os detalhes de um usuário específico pelo ID.

Parâmetro:

id: ID do usuário.
Exemplo de requisição:

URL: /Usuario/DetalhesUsuario/1
Resposta esperada:
json
Copiar código
{
  "Id": 1,
  "Nome": "João",
  "Sobrenome": "Silva",
  "Email": "joao.silva@email.com",
  "DataNascimento": "1990-05-12",
  "Sexo": "Masculino",
  "TipoPlano": "Premium",
  "Cep": "12345-678"
}
5. Exibição de Detalhes do Paciente
Endpoint: /Paciente/DetalhesPaciente/{id}

Método HTTP: GET

Descrição: Este endpoint retorna os detalhes de um paciente específico pelo ID.

Parâmetro:

id: ID do paciente.
Exemplo de requisição:

URL: /Paciente/DetalhesPaciente/1
Resposta esperada:
json
Copiar código
{
  "Id": 1,
  "Nome": "Maria Oliveira",
  "Idade": 30,
  "Email": "maria.oliveira@email.com"
}
6. Exibição de Detalhes do Prontuário
Endpoint: /Prontuario/DetalhesProntuario/{id}

Método HTTP: GET

Descrição: Este endpoint retorna os detalhes de um prontuário específico pelo ID.

Parâmetro:

id: ID do prontuário.
Exemplo de requisição:

URL: /Prontuario/DetalhesProntuario/1
Resposta esperada:
json
Copiar código
{
  "Id": 1,
  "Nome": "Prontuário de Maria Oliveira",
  "TipoPlano": "Premium",
  "Descricao": "Consulta de rotina",
  "StatusProntuario": "Ativo",
  "PacienteId": 1
}
