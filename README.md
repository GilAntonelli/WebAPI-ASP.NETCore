# WebAPI-ASP.NETCore
Projeto contendo duas WebAPI desenvolvidas em APS.NETCore.

- A WebAPI TaxaJuros que devolve o valor fixo da taxa de juros (0,01).
- A WebAPI CalculaJuros que calcula juros compostos de um valor decimal passado por parâmetro.
  Também é passado por parâmetro os meses da operação e taxa de juros é consultada na WebAPI TaxaJuros.
- Possui também dois projetos de testes utilizando o xunit test para fazer testes em cada uma das WebAPI.
- Possui também o arquivo dockerfile já configurado em cada WebAPI para criar uma imagem e rodar no docker.
