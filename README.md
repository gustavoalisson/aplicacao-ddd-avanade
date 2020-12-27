# Projeto: Desenvolvendo sua aplicação com C# usando DDD

## Conceito de DDD
> é uma abordagem de desenvolvimento de software em que o design é orientado pelo domínio, ou seja, pela área de conhecimento à qual o software se aplica. Uma outra forma de dizer, que o design é orientado pelas regras de negócio. 

## Resumo de como se faz o DDD (Pesquisado na Web)

Como se faz DDD?
O objetivo é perseguido aplicando-se um conjunto de conceitos, design patterns, e até comportamentos (das pessoas) no desenvolvimento do software. Veja alguns (repito, alguns) exemplos:

### a) Conceitos
Model: Descrição de alguns aspectos do domínio. Na prática, é a modelagem dos objetos de negócio.

Bounded Context: Um único model não precisa resolver todos os problemas de um sistema complexo. Um sistema pode ter múltiplos models e os limites de um model devem estar bem definidos. Cada model evolui sem distrair-se com os demais.

Ubiquitous Language: Uma linguagem comum, capaz de descrever o domain, o model, o contexto, e que deve ser praticada por todos - desenvolvedores, especialistas em negócio, e pelo próprio código. Ou seja, o código fala a linguagem do negócio. Uma mudança em um termo de negócio implicará na mudança do código. É difícil eleger o conceito mais importante do DDD, mas se eu tivesse de fazê-lo, escolheria a Ubiquitous Language.

### b) Design patterns
Entities: Objetos que possuem identidade e que são distinguidos por esta identidade e não apenas por suas características. Obviamente, estamos falando de identitidade para o negócio. Além de atributos, Entities também podem ter comportamentos.

Aggregates: Conjunto de entities agregadas por uma entity raiz. Algumas entities não possuem por si só um significado global no domínio; ao invés, elas só fazem sentido quando precedidas por uma entity "pai". Esta entity pai é então a raiz de um aggregate e as entities filhas só podem ser acessadas através desta entity pai.

Services: Operações de negócio que não são responsabilidade de nenhuma entity em particular.

Infelizmente, é comum estes e outros design patterns do DDD serem confundidos com outros puramente técnicos por conta dos nomes semelhantes.

### c) Comportamentos
Continuous integration: Desenvolvido por um time, o model pode acabar evoluindo em direções opostas, ser fragmentado ou quebrado. É necessário integrar o código continuamente, com execução de testes automatizados.

Hands-on Modelers: Quem modela também sabe codificar e de fato o faz, ainda que menos que outras pessoas no time (exceção ao especialista de negócio, que ajuda a modelar mas não programa). Além disso, todos que programam entendem o model, participam de discussões sobre ele e estão em contato constante com o especialista de negócio.

Refactoring: Não apenas para resolver aspectos técnicos do código sem afetar comportamento, mas também para aprimorar o próprio model.

Objetivo do projeto: Desenvolver um projeto aplicando os conceitos de Domain Driven Design.


Observação: Para criação do projeto foi utilizado artigo e aula teórica/prática. Segue referências: 
* https://medium.com/beelabacademy/implementando-na-pr%C3%A1tica-rest-api-com-conceitos-de-ddd-net-2160291a44b7
* https://www.youtube.com/watch?list=PLfpYVugeLJLZMwhCbQVLJ_OGUPLDNqKkN&v=plS-rf2UIPI&feature=emb_title

## Fluxo resumido dos conceitos DDD

![alt text](https://miro.medium.com/max/2400/0*3LCl6RxN9cyYyl8z.jpeg)
