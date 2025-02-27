# Sistema de Gerenciamento de Reservas de Hotel

## Objetivo
Este projeto tem como objetivo implementar um sistema de gerenciamento de reservas de hotel utilizando diversas técnicas e boas práticas de desenvolvimento de software. O projeto visa estudar e aplicar conceitos como arquitetura hexagonal, Domain-Driven Design (DDD), Test-Driven Development (TDD), CQRS, princípios SOLID, padrões de máquina de estados, e outros.

## Funcionalidades
- Criação de novos clientes
- Gerenciamento de quartos de hotel
- Reserva de quartos pelos clientes

## Técnicas Utilizadas

1. **Domain-Driven Design (DDD)**
   - Utilização de conceitos chave como DTOs, Value Objects, Entities and Models, Aggregators e definição de bounded context.

2. **Hexagonal Architecture**
   - Adotada como padrão arquitetural principal, com paralelos constantes com Clean Architecture.

3. **Test-Driven Development (TDD)**
   - Foco na escrita de código altamente testável.

4. **CQRS (Command Query Responsibility Segregation)**
   - Separação de comandos e queries, permitindo a separação de leitura e escrita em bancos ou microserviços distintos quando desejável.

5. **Princípios SOLID**
   - Base para organização e definição de padrões mínimos de qualidade do código, com ênfase em single responsibility principle, open/close principle e dependency inversion com injeção de dependência.

6. **Padrões de Máquina de Estados**
   - Utilização de padrões de máquina de estados para mudança de estado de entidades com 100% de cobertura de testes unitários.

7. **Result Pattern**
   - Padrão utilizado para comunicação entre camadas.

8. **Null Object Pattern**
   - Controle de fluxo de exceções.

9. **Injeção de Dependência**
   - Gestão de dependências do sistema.

10. **Entity Framework + Migrations**
    - Utilização do Entity Framework para mapeamento objeto-relacional e gerenciamento de migrações de banco de dados.

11. **Feature Sliding**
    - Implementação de novas funcionalidades de forma incremental e controlada.

## Tecnologias Utilizadas
- **Linguagem**: C#
- **Framework**: .NET
- **ORM**: Entity Framework

## Estrutura do Projeto
- **src**: Contém o código fonte do sistema.
- **tests**: Contém os testes unitários e de integração.
- **docs**: Contém a documentação do projeto.

## Como Executar o Projeto

1. Clone o repositório:
```bash
    git clone https://github.com/JefMacedo/Hotel-booking-system.git
```

2. Navegue até o diretório do projeto:
```bash
   cd Hotel-booking-system
```

3. Restaure as dependências do projeto:
```bash
   dotnet restore
```

4. Execute o projeto:
```bash
    dotnet run
```

5. Execute os testes:
```bash
   dotnet test
```

## Contribuição
Sinta-se à vontade para contribuir com o projeto. Por favor, abra uma issue ou envie um pull request.

## Licença
Este projeto está licenciado sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.







