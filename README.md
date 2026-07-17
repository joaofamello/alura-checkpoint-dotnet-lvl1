# alura-checkpoint-dotnet-lvl1

API de apoio ao controle de cursos, estudantes e matrículas, com autenticação, autorização por perfis e documentação via Swagger. O projeto segue os requisitos propostos para uma aplicação ASP.NET Core Web API com JWT, Identity, EF Core e boas práticas de organização por DTOs, validações e paginação.

## Objetivo do projeto

Construir uma API para uma plataforma acadêmica com as seguintes responsabilidades:

- autenticar usuários com registro e login;
- emitir e validar JWT;
- controlar acesso por papéis: Admin, Instructor e Student;
- gerenciar cursos, estudantes e matrículas;
- expor documentação clara para consumo e testes da API.

## Requisitos técnicos

- .NET SDK 10.0 ou superior compatível com o target do projeto (`net10.0`);
- ASP.NET Core Web API;
- EF Core com SQLite em ambiente local;
- ASP.NET Core Identity;
- autenticação JWT Bearer;
- Swagger/OpenAPI habilitado em desenvolvimento.

## Requisitos funcionais previstos

- autenticação de usuários com JWT;
- autorização por perfis: Admin, Instructor e Student;
- CRUD de cursos com listagem pública, paginação e filtros;
- cadastro e gerenciamento de estudantes;
- matrícula de estudantes em cursos sem duplicidade;
- validações de domínio, como título mínimo para curso e e-mail válido e único para estudante;
- respostas de erro padronizadas;
- documentação Swagger com suporte ao esquema Bearer.

## Como rodar localmente

1. Instale o SDK da .NET compatível com o projeto.
2. Abra um terminal na raiz do repositório.
3. Acesse a pasta da aplicação:

```bash
cd MatriculasAPI
```

4. Restaure as dependências:

```bash
dotnet restore
```

5. Execute a aplicação:

```bash
dotnet run --launch-profile https
```

Se preferir HTTP, use o perfil `http`:

```bash
dotnet run --launch-profile http
```

## Endpoints locais

- HTTPS: https://localhost:7034
- HTTP: http://localhost:5102
- Swagger: disponível em ambiente de desenvolvimento

## Observações

- O projeto está configurado para desenvolvimento com Swagger habilitado apenas no ambiente `Development`.
- As credenciais e chaves sensíveis devem ser mantidas fora do repositório, usando variáveis de ambiente ou `user-secrets`.
- Quando as migrations estiverem presentes, aplique-as antes de iniciar a API pela primeira vez.