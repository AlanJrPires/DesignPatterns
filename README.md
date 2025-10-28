# DesignPatternsDemo

## Descrição do Projeto

**DesignPatternsDemo** é uma aplicação educacional desenvolvida com .NET Core 8 e C# 12, criada para demonstrar a aplicação prática dos principais **padrões de design orientados a objetos**. A proposta é facilitar o aprendizado dos padrões em um cenário realista: um sistema de propostas de seguro para carros e residências.

O projeto apresenta exemplos concretos e comentados dos três principais grupos de padrões: **criacionais**, **estruturais** e **comportamentais**, visando uma compreensão clara e aplicada.

---

## Público Alvo

Este projeto é ideal para:

- Desenvolvedores iniciantes ou intermediários em C# que desejam aprender padrões de design.
- Estudantes e profissionais de software interessados em arquitetura orientada a objetos.
- Instrutores que buscam material didático para ensino de padrões de design em C#.
- Qualquer programador que queira entender como aplicar padrões em projetos reais usando .NET Core e recursos modernos do C# 12.

---

## Estrutura da Solução

A solução está organizada em quatro projetos distintos para facilitar a navegação e entendimento pedagógico:

| Projeto                          | Pasta/Subpasta             | Arquivos principais                                   | Descrição                                      |
|----------------------------------|----------------------------|-------------------------------------------------------|------------------------------------------------|
| DesignPatternsDemo.Creational    | Singleton                  | InsuranceConfig.cs                                    | Configuração global (Singleton)                |
|                                  | FactoryMethod              | InsuranceProposalFactory.cs, 
                                                                  CarInsuranceProposalFactory.cs, 
                                                                  HomeInsuranceProposalFactory.cs, 
                                                                  InsuranceProposal.cs, 
                                                                  CarInsuranceProposal.cs, 
                                                                  HomeInsuranceProposal.cs                              | Fabricação de propostas (Factory Method)       |
| DesignPatternsDemo.Structural    | Adapter                    | IExternalQuotationService.cs, 
                                                                  ExternalQuoteApi.cs, 
                                                                  QuotationAdapter.cs                                   | Adaptação de API externa                       |
|                                  | Decorator                  | InsuranceProposalDecorator.cs, 
                                                                  SpecialDiscountDecorator.cs                           | Adição dinâmica de funcionalidades (Decorator) |
| DesignPatternsDemo.Behavioral    | Observer                   | IProposalObserver.cs, 
                                                                  Agent.cs, 
                                                                  ProposalSubject.cs                                    | Notificação de agentes (Observer)              |
|                                  | Strategy                   | IPremiumCalculationStrategy.cs, 
                                                                  CarPremiumCalculationStrategy.cs, 
                                                                  HomePremiumCalculationStrategy.cs, 
                                                                  PremiumCalculator.cs                                  | Estratégias de cálculo de prêmio (Strategy)    |
| DesignPatternsDemo.ConsoleApp    | -                          | Program.cs                                            | Demonstração prática dos padrões               |


- **DesignPatternsDemo.Creational**: Contém padrões de criação de objetos (Singleton, Factory Method) aplicados à criação e validação de propostas de seguro.
- **DesignPatternsDemo.Structural**: Exemplos de padrões que organizam a estrutura do código, como Adapter para integrar API externa e Decorator para adicionar funcionalidades como descontos.
- **DesignPatternsDemo.Behavioral**: Apresenta padrões que definem comportamentos, incluindo Observer para notificar agentes seguradores e Strategy para cálculo de prêmio conforme tipo do seguro.
- **DesignPatternsDemo.ConsoleApp**: Aplicação console que demonstra o uso prático de cada padrão, com mensagens explicativas para facilitar o aprendizado.

---

## Detalhes dos Padrões Implementados

### Padrões Criacionais

- **Singleton**  
  Controla uma instância única para configuração global da aplicação (exemplo: nome da seguradora).

- **Factory Method**  
  Define uma interface para criar propostas de seguro, delegando a subclasses a decisão do tipo específico (carro ou casa).

### Padrões Estruturais

- **Adapter**  
  Converte a interface de uma API externa incompatível em uma interface compreensível pelo sistema de seguro.

- **Decorator**  
  Permite adicionar responsabilidades (como descontos) às propostas de seguro dinamicamente, sem modificar as classes originais.

### Padrões Comportamentais

- **Observer**  
  Implementa um mecanismo de notificação para agentes seguradores quando novas propostas são criadas ou modificadas.

- **Strategy**  
  Define diferentes algoritmos para cálculo do prêmio de seguro, podendo alternar dinamicamente entre estratégias para carro ou residência.

---

## Demonstração

Execute o projeto `DesignPatternsDemo.ConsoleApp` para ver uma demonstração detalhada. O programa:

- Exibe a configuração Singleton.
- Cria propostas via Factory Method.
- Consulta cotações externas com Adapter.
- Aplica descontos com Decorator.
- Notifica agentes usando Observer.
- Calcula prêmios com múltiplas estratégias via Strategy.

Mensagens explicativas guiam o usuário em cada etapa.

---

## Como Usar

1. Faça o clone deste repositório:
git clone <url-do-repositório>

text

2. Abra a solução no Visual Studio 2022.

3. Compile todos os projetos.

4. Defina `DesignPatternsDemo.ConsoleApp` como projeto de inicialização.

5. Execute para visualizar a demo passo a passo.

---

## Contribuição

Contribuições são bem-vindas para:

- Inclusão de novos padrões de design.
- Melhorias nos exemplos e documentação.
- Implementação de interfaces gráficas ou APIs web para expandir a demonstração.

Sinta-se à vontade para abrir issues e pull requests.

---

## Licença

Este projeto é de código aberto e pode ser utilizado livremente para fins educacionais e profissionais.

---

## Contato

Para dúvidas ou sugestões, abra uma issue no repositório ou entre em contato com o mantenedor do projeto.

---
