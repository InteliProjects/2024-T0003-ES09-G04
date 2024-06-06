# Documentação do infográfico
![image](https://github.com/Inteli-College/2024-T0003-ES09-G04/assets/99216420/f4dac16e-1874-47b0-a7c4-41ec4bada120)

## 1. Requisitos Funcionais e Não Funcionais

### a) Demonstração de Casos de Uso

- **Tabela de Widgets:** Interface de tabela exibindo todos os widgets existentes.
- **Adicionar Widget:** Permite adicionar novos widgets com nome, pergunta, rating e justificativa.
- **Visualizar Detalhes:** Clique em um widget para ver nome, pergunta, rating e justificativa.
- **Editar e Excluir Widget:** Edite ou remova widgets existentes.
- **Gerar HTML:** Gera HTML incorporável ao site para exibir o widget.

### b) Explicação das Funcionalidades Implementadas

- **Tabela de Widgets:** Permite visualizar todos os widgets cadastrados em formato de tabela.
- **Adicionar Widget:** Permite ao usuário adicionar novos widgets, inserindo nome, pergunta, rating e justificativa.
- **Visualizar Detalhes:** Ao clicar em um widget na tabela, exibe os detalhes do widget selecionado.
- **Editar e Excluir Widget:** Permite editar ou excluir widgets existentes.
- **Gerar HTML:** Funcionalidade para gerar HTML incorporável para exibição dos widgets em sites externos.

## 2. Informações sobre a Construção do Componente de Frontend

### a) Frameworks Utilizados

- React

### b) Tecnologias Utilizadas

- Tailwind CSS

### c) Padrões de Projeto Implementados

- Utilização do padrão de componentes para uma arquitetura modular e reutilizável.

## 3. Informações sobre a Construção do Componente de Backend

### a) Frameworks Utilizados

- .NET

### b) Tecnologias Utilizadas

- C#
- Visual Studio
- JetBrains Rider

## 4. Suíte de Testes

### a) Tipos de Testes Implementados

- Testes Unitários
- Testes de Integração
- Testes de Qualidade de Código (SonarQube)
- Testes de Carga (K6)

### b) Percentual de Cobertura de Testes

- Testes Unitários: 50%
- Testes de Integração: 80%
- Testes de Qualidade de Código (SonarQube): 100%
- Testes de Carga (K6): 100%

### c) Dados de Execução dos Testes das Sprints 3, 4 e 5

![image](https://github.com/Inteli-College/2024-T0003-ES09-G04/assets/99216420/9dea55af-e7d0-48c7-9e4d-b6f182f7f1ff)


## 5. Esteira de Integração Contínua

### a) Breve Explicação da Esteira

- **Análise Estática de Código:** Ferramentas como SonarQube são utilizadas para realizar análise estática do código-fonte, identificando potenciais problemas de qualidade, como duplicação de código, vulnerabilidades de segurança e más práticas de codificação.

- **Implantação Automática em Ambientes de Teste ou Produção:** Se todos os testes forem aprovados e a análise estática de código não encontrar problemas críticos, as alterações são automaticamente implantadas em ambientes de teste ou produção, garantindo uma entrega contínua e rápida de novas funcionalidades para os usuários finais.

### b) Tecnologias Utilizadas

- SonarQube (para análise estática de código)

### c) Regras Implementadas

- A esteira de integração contínua é acionada automaticamente a cada commit no repositório de código.
- Os testes automatizados devem ser aprovados antes que as alterações sejam mescladas no branch principal.
- A análise estática de código deve passar sem violações críticas de qualidade.
- As implantações automáticas só ocorrem em ambientes de produção após testes bem-sucedidos em ambientes de teste.
