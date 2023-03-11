# processamento-de-contratos
Um sistema que processa contratos com taxas e juros de acordo com a Interface. Utiliza somente C#.

Implementação do Main Program. Nessa tela nós entramos com os dados do contrato (número, data e valor do contrato), a partir disso, temos condições de instanciar o nosso NEW CONTRACT.

Após isso, entramos com o dado que faltava (months, que são as quantidades de parcelas) e instanciamos o NEW PALPAYSERVICE dentro do NEW CONTRACTSERVICE.

Por fim, para encontrarmos o valor de cada parcela utilizamos o FOREACH, que para cada parcela dentro da lista de parcelas, nos retornará as parcelas já com o todo o cálculo de taxas e juros de acordo com a lógica implementada na classe de origem.


![Screenshot_15](https://user-images.githubusercontent.com/106346422/224504032-e512c755-9ff6-4167-942f-e20333845b0f.png)
