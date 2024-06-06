# Documentação do Dashboard utilizando Prometheus e Grafana

## Introdução

Este documento descreve o dashboard desenvolvido para monitoramento da nossa aplicação utilizando as ferramentas Prometheus e Grafana. O objetivo deste dashboard é fornecer uma visão abrangente e em tempo real do desempenho e da saúde da aplicação.

## 1. Visão Geral do Dashboard

O dashboard é composto por uma série de painéis que exibem métricas importantes relacionadas à infraestrutura, desempenho e utilização da aplicação. Ele oferece uma interface intuitiva e personalizável para monitorar e analisar os dados coletados pelo Prometheus.

## 2. Painéis Principais

### a) Métricas da Aplicação

Este painel exibe métricas específicas da aplicação, como o número de solicitações HTTP por segundo, o tempo de resposta médio das solicitações e a taxa de erros.

### b) Utilização de Recursos

Este painel mostra a utilização de recursos do sistema, incluindo CPU, memória e espaço em disco, tanto para a aplicação quanto para os servidores em que ela está hospedada.

### c) Status dos Serviços

Este painel exibe o status dos serviços essenciais da aplicação, como banco de dados, cache e serviços de terceiros, destacando eventuais problemas ou falhas.

## 3. Configuração

### a) Prometheus

O Prometheus é responsável por coletar métricas da aplicação e armazená-las em seu banco de dados de séries temporais.

- **Scraping Configuration:** Configurações para o scraping de métricas da aplicação, especificando endpoints HTTP a serem monitorados.

### b) Grafana

O Grafana é utilizado para criar e visualizar o dashboard, permitindo a configuração de painéis personalizados com base nos dados do Prometheus.

- **Data Source Configuration:** Configurações para conectar o Grafana ao Prometheus como fonte de dados.

## 4. Uso e Navegação

O dashboard é acessado através de um navegador web padrão, utilizando a URL fornecida pela equipe responsável pela configuração da infraestrutura.

- **Painéis Interativos:** Os painéis são interativos e permitem a filtragem e o zoom nos dados exibidos para uma análise mais detalhada.


## Conclusão

O dashboard desenvolvido utilizando Prometheus e Grafana fornece uma poderosa ferramenta de monitoramento e análise para garantir o desempenho e a disponibilidade da nossa aplicação. Ele permite uma fácil visualização das métricas importantes e ajuda a identificar e solucionar problemas rapidamente.

![image](https://github.com/Inteli-College/2024-T0003-ES09-G04/assets/99216420/eabc631c-f76f-4ba6-9a4f-1e01d03b76c9)

![image](https://github.com/Inteli-College/2024-T0003-ES09-G04/assets/99216420/4d580983-55a1-49ae-a492-558a6452d5b4)

![image](https://github.com/Inteli-College/2024-T0003-ES09-G04/assets/99216420/1ac1d338-854a-41e1-b5d1-bfc6047dc333)

![image](https://github.com/Inteli-College/2024-T0003-ES09-G04/assets/99216420/47e1e1a7-fa64-4eb0-b74d-65a143fbfffb)

![image](https://github.com/Inteli-College/2024-T0003-ES09-G04/assets/99216420/bb053150-357b-404a-9570-be5551e5b167)

### Vídeo do dashboard e aplicação do APM

link: https://drive.google.com/file/d/1PhVNWGXpLy-PAITRobCzdFnhUphUSuv5/view?usp=sharing
