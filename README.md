# WebAPI-ASP.NETCore
Projeto contendo duas WebAPI desenvolvidas em APS.NETCore.

- A WebAPI TaxaJuros apenas devolve o valor fixo "0,01" representando a taxa de juros da operação.
- A WebAPI CalculaJuros calcula e devolve um valor acrescido dos juros compostos. Valor é um decimal
  passado por parêmtro e também é passado por parâmetro os meses da operação. 
  A Taxa de juros é consultada na WebAPI TaxaJuros.
- Possui também dois projetos de testes utilizando o xunit test para fazer testes em cada uma das WebAPI.
- Possui também o arquivo dockerfile já configurado em cada WebAPI para criar uma imagem e rodar no docker.
