# Processo para alteração de artefatos de software em ambiente produtivo

## Preparação

**1. Revisão de Código:** Antes de qualquer alteração em produção, o código deve ser revisado e aprovado em ambientes de desenvolvimento e teste. Use os testes unitários e de integração (por exemplo, CreateWidgetUnitTest.cs, GetAllWidgetsTest.cs) para garantir a qualidade.

**2. Testes de Carga:** Utilize os scripts k6 (por exemplo, TestGetAllWidgets.js, TestPostWidget.js) para simular carga e verificar a performance e estabilidade das novas alterações sob condições variadas.

**3. Backup de Dados:** Faça backups completos dos bancos de dados e arquivos de configuração. Isso é crucial para o plano de rollback.

**4. Congelamento de Mudanças:** Estabeleça um período de congelamento de código, onde nenhuma nova mudança é permitida até a conclusão bem-sucedida da atualização em produção.

## Implementação

**5. Migração de Banco de Dados:** Execute as migrações de banco de dados (por exemplo, 20240228042848_init.cs, 20240228195051_CreateWidgetsTable.cs) em um ambiente controlado primeiro, para garantir que tudo funciona conforme esperado.

**6. Deploy:** Faça o deploy dos novos artefatos de software. Utilize ferramentas de integração e entrega contínua para automatizar esse processo, garantindo que os artefatos corretos sejam implantados na versão correta.

**7. Monitoramento:** Após o deploy, monitore os logs, o desempenho e a estabilidade do sistema. As ferramentas de monitoramento e alerta (como o Prometheus e o Grafana) devem estar configuradas para detectar qualquer comportamento inesperado imediatamente.

**8. Validação Pós-Deploy:** Execute testes de verificação pós-deploy para garantir que todos os componentes estejam funcionando conforme o esperado.

## Comunicação

**9. Documentação:** Documente todas as mudanças realizadas, incluindo detalhes sobre as migrações, os testes realizados e quaisquer incidentes ou dificuldades enfrentadas.

**10. Avisos:** Informe todas as equipes relevantes sobre a conclusão do deploy, incluindo quaisquer mudanças na operação ou na manutenção que eles precisam conhecer.


# Plano de rollback

## Trigger de Rollback:

**1. Critérios de Falha:** Antes de tudo, a equipe da Track deve  estabelecer critérios claros para quando um rollback deve ser iniciado, como falhas críticas, problemas de performance inaceitáveis ou bugs graves que impactam a operação.

## Execução do Rollback:

**2. Reversão do Deploy:** Tenha procedimentos prontos para reverter rapidamente o deploy dos artefatos para as versões anteriores estáveis. Um procedimento pode ser ter scripts automatizados prontos para reverter rapidamente o código para a última versão estável, que pode ser feito usando ferramentas de CI/CD que mantêm o histórico de todas as versões e permitem reverter para qualquer versão anterior com facilidade.

**3. Restauração de Dados:** Se as mudanças incluírem alterações no banco de dados, prepare-se para restaurar os dados a partir dos backups feitos antes do deploy.

**4. Verificação Pós-Rollback:** Realize testes para confirmar que a aplicação retornou ao estado funcional anterior e está estável.

## Comunicação:

**5. Notificação:** Informe imediatamente todas as equipes envolvidas sobre o rollback, incluindo detalhes sobre o motivo e as expectativas de resolução.

## Análise e Melhoria:

**6. Revisão:** Após a estabilização do ambiente, conduza uma revisão post-mortem para entender as causas do problema, documentar lições aprendidas e implementar melhorias no processo.

## Definição de Ambientes

**Ambiente de Desenvolvimento (Dev):** Utilizado pelos desenvolvedores para escrever e testar código. Aqui, são realizados testes unitários e de integração para garantir a funcionalidade básica antes de avançar para ambientes mais restritivos.

**Ambiente de Teste de Aceitação do Usuário (UAT):** Ambiente que replica o ambiente de produção o mais próximo possível. Utilizado para testes de aceitação pelo usuário, testes de regressão e outros testes de validação para garantir que o software atende aos requisitos do usuário antes de ser movido para produção.

**Ambiente de Produção (Prod):** Onde o software é implantado para uso real pelos usuários finais. Deve ser monitorado de perto para garantir a estabilidade e a segurança do sistema.
