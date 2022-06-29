# Credit Suisse - RISCO DE DESENVOLVIMENTO DE TI

## Problema: Categorizar negócios na carteira de um banco

```

Um banco tem uma carteira de milhares de negócios e eles precisam ser categorizados. Uma troca é uma negociação comercial
cliente entreabankanda. Atrade tem muitas características, incluindo:
```

 Atualmente, existem três categorias (em ordem de precedência):
 ```
1. EXPIRADO: Operações cuja próxima data de pagamento esteja atrasada em mais de 30 dias com base em uma data de referência que será
seja dado.
2. ALTO RISCO: Operações com valor superior a 1.000.000 e cliente do Setor Privado.
3. RISCO MÉDIO: Operações com valor superior a 1.000.000 e cliente do Setor Público.
```
Estruture sua lógica utilizando práticas DDD e aplicando camadas como serviços, aplicação e Domínios.

Pergunta 1: Escreva um aplicativo de console C# usando um design orientado a objetos que classifique todos os negócios em um determinado portfólio.
Tenha em mente que a aplicação real pode ter dezenas de categorias, então seu design deve ser extensível permitindo que essas
categorias para serem facilmente adicionadas/removidas/modificadas no futuro. O código pode ser enviado em um link do GitHub.



Entrada

A primeira linha da entrada é a data de referência.
A segunda linha contém um inteiro n, o número de negócios em O portfólio.
As próximas n linhas contêm 3 elementos cada (separados por um espaço).
Primeiro um duplo que representa valor da negociação, segundo uma string que representa o setor do cliente e terceiro uma data que representa o próximo
Pagamento Pendente.
Todas as datas estão no formato mm/dd/aaaa.

Resultado
N linhas com a categoria de cada um dos n negócios.

Exemplo de entrada

11/12/2020

4

2080000 Privado 29/12/2025
400008 Público 01/07/2020
5000000 Público 01/02/2024
3000000 Público 26/10/2023

Saída de amostra
ALTO RISCO

EXPIRADO
RISCO MÉDIO
RISCO MÉDIO

Questão 2:
Foi criada uma nova categoria chamada PEP (pessoa politicamente exposta).
Além disso, uma nova propriedade bool IsPoliticalExposed foi criado na interface ITrade. Um comércio deve ser classificado como PEP se IsPoliicallyExposed é verdadeiro.
Descreva em no máximo 1 parágrafo o que você deve fazer em seu projeto para dar conta dessa nova categoria.
