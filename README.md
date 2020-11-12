#link do projeto funcionando

https://testedevweb.azurewebsites.net/

# O Desafio 

Teste Web Lanches

Somos uma startup do ramo de alimentos e precisamos de uma aplicação web para
gerir nosso negócio. Nossa especialidade é a venda de lanches, de modo que alguns
lanches são opções de cardápio e outros podem conter ingredientes personalizados.
A seguir, apresentamos a lista de ingredientes disponíveis:
INGREDIENTE Valor
Alface R$ 0,40
Bacon R$ 2,00
Hambúrguer de carne R$ 3,00
Ovo R$ 0,80
Queijo R$ 1,50
Segue as opções de cardápio e seus respectivos ingredientes:
LANCHE INGREDIENTES
X-Bacon Bacon, hambúrguer de carne e queijo
X-Burger Hambúrguer de carne e queijo
X-Egg Ovo, hambúrguer de carne e queijo
X-Egg Bacon Ovo, bacon, hambúrguer de carne e queijo
O valor de cada opção do cardápio é dado pela soma dos ingredientes que compõe o
lanche. Além destas opções, o cliente pode personalizar seu lanche e escolher os
ingredientes que desejar. Nesse caso, o preço do lanche também será calculado pela
soma dos ingredientes.
Existe uma exceção à regra para o cálculo de preço, quando o lanche pertencer à uma
promoção. A seguir, apresentamos a lista de promoções e suas respectivas regras de
negócio:
PROMOÇÃO REGRA DE NEGÓCIO
Light Se o lanche tem alface e não
tem bacon, ganha 10% de desconto.
Muita carne A cada 3 porções de carne o cliente só
paga 2. Se o lanche tiver 6 porções, o
cliente pagará 4. Assim por diante...
Muito queijo A cada 3 porções de queijo o cliente
só paga 2. Se o lanche tiver 6 porções, o
cliente pagará 4. Assim por diante...
