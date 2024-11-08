# Sistema de Gestão de Cadastro e Sinistros

Este projeto é uma aplicação ASP.NET Core que permite o gerenciamento de usuários e pacientes, facilitando o cadastro, a atualização e a visualização de informações relevantes para a área da saúde.

## Índice

- [Descrição do Projeto](#descrição-do-projeto)
- [Arquitetura do Projeto](#arquitetura-do-projeto)
- [Funcionalidades](#funcionalidades)
  - [Cadastro de Usuário](#cadastro-de-usuário)
  - [Gerenciamento de Pacientes](#gerenciamento-de-pacientes)
  - [Previsão de Sinistros](#previsão-de-sinistros)
- [Contribuição](#contribuição)

## Descrição do Projeto

Esta aplicação visa otimizar o processo de cadastro e gerenciamento de informações sobre usuários e pacientes, além de possibilitar a previsão de sinistros com base no histórico médico. O sistema é construído utilizando o padrão de arquitetura em camadas, separando as preocupações de apresentação, lógica de negócio e acesso a dados.

## Arquitetura do Projeto

A arquitetura do projeto é dividida nas seguintes camadas:

- **Controllers**: Responsáveis por receber e tratar as requisições HTTP. Interagem com os serviços para executar a lógica de negócio.
- **Domain**: Contém as entidades que representam os dados e as regras de negócio.
- **Application**: Define interfaces e serviços que implementam a lógica de negócio, facilitando a reutilização de código.
- **Infrastructure**: Implementações dos repositórios que acessam o banco de dados e gerenciam as operações de CRUD.
- **ViewModels**: Estruturas utilizadas para transferir dados entre as views e o controlador.

## Funcionalidades

### Usuário

- **Endpoint**: `POST /api/cadastro`
- **Descrição**: Permite o cadastro de um novo usuário. Os dados são validados para garantir a integridade.
- **Exemplo de Requisição**:
    ```json
    {
        "nome": "João",
        "sobrenome": "Silva",
        "email": "joao.silva@example.com",
        "senha": "senha123",
        "dataNascimento": "1990-01-01",
        "sexo": "Masculino",
        "tipoPlano": "Premium",
        "cep": "12345-678"
    }
    ```

### Gerenciamento de Pacientes

- **Criar Paciente**: `POST /api/paciente/create`
- **Obter Todos os Pacientes**: `GET /api/paciente/all`
- **Exemplo de Requisição para Criar Paciente**:
    ```json
    {
        "nome": "Maria",
        "tipoPlano": "Básico",
        "sexo": "Feminino",
        "cep": "87654-321",
        "dataNascimento": "1985-05-15",
        "cadastroId": 1
    }
    ```

### Gerenciamento de Prontuarios

- **Criar Prontuario**: `POST /api/prontuario/create`
- **Obter Todos os Prontuarios**: `GET /api/prontuario/all`
- **Exemplo de Requisição para Criar Paciente**:
    ```json
    {
        "prontuarioId": 10
        "nome": "Maria da Silva",
        "tipoPlano": "Odontológico",
        "descricao": "Feminino",
        "statusprontuario": "Ativo",
    }
    ```



### Previsão de Sinistros

Um serviço que verifica automaticamente se um paciente apresenta risco de sinistros, com base no seu histórico médico e no número de sinistros anteriores.


Autor: Vinicius Lorenzetti
