KISS - Keep it Simple and Sweet / Stupid
##Mantenha Simples, Estúpido
###a simplicidade deve ser um objetivo fundamental no design 
###e a complexidade desnecessária deve ser evitada.
###O código deve ser fácil de ler e entender com o mínimo esforço possível.


DRY - Don't Repeat YourSelf
##Não se repita
###Cada parte do conhecimento deve ter uma representação única,
###não ambígua e definitiva dentro do sistema

YAGNI - You Ain't Gonna Need It 
#você não vai precisar
##não implemente algo até que seja necessário.
#Sempre implemente as coisas quando você realmente precisa delas,
#nunca quando você apenas prevê que precisa delas.
#Isso leva ao inchaço do código; o software fica maior e mais complexo.
#Você economiza tempo, porque você evita escrever código que você não vai precisar no momento;
#Seu código fica melhor, porque você evita poluir o código com 'palpites' que acabam, na maioria dos casos, sendo palpites errados;
#Você acha mesmo que vai economizar tempo global gastando mais tempo agora do que no futuro ?

Hollywood Principle
#Não nos telefone, nós telefonaremos para você
#não nos chame, nós chamaremos você
##“Em outras palavras, os componentes de alto nível dizem aos
##componentes de baixo nível: Não nos telefone, nós telefonaremos para você.”

TDA - Tell-Don't-Ask
#Não pergute ordene
#O princípio afirma que você deve dizer aos objetos quais ações você deseja
#que eles realizem , em vez de realizar perguntas sobre o estado de um objeto
#e depois fazer uma decisão-se sobre a ação que você deseja realizar. 
#Isso ajuda a alinhar as responsabilidades e evitar forte acoplamento entre as classes.

You Ain’t Gonna Need It (YAGNI )

LoD - Law of Demeter
##Também conhecido como Mínimo Conhecimento
###Não fale com estranhos. Converse apenas com amigos.
###só podemos invocar métodos que pertençam ao próprio objeto

POLA - Principle Of Least Astonishment

SLAP - Single Level of Abstraction Principle - Nível Único de Abstração
Essa regra diz que cada linha de código em um método deve ter o mesmo 
nível de abstração, ou seja, para evitar misturar detalhes de 
alto e baixo nível uns com os outros.
Prós
Legibilidade e manutenção de código mais fácil

#Composition Over Inheritance
#Encapsulate What Changes

CPP - Common Closure Principle - Princípio Comum de Fechamento
#As aulas que acontecem juntas devem ser empacotadas juntas
#Isolamento de mudanças no escopo do pacote
#Intimamente relacionado ao OCP no nível de classe
#Isso significa que as classes que mudam juntas quando os requisitos mudam devem ser colocadas no mesmo pacote.
Prós
Isso minimiza o número de pacotes a serem alterados quando os requisitos mudam.

REP - Reuse-release equivalence principle - Princípio de equivalência de liberação de reuso
Reutilizar código não é copiar uma classe de um projeto para outro. Se quisermos reutilizar o código, ele deve ser separado em uma biblioteca ou módulo, que podemos usar novamente mais tarde.
As classes destinadas à reutilização devem estar em um pacote, que pode se tornar uma biblioteca reutilizável. Aqueles que não se destinam a reutilização não devem ser incluídos aqui. Resumindo - ou todos são reutilizáveis ​​ou nenhum.
Também deve haver classes que pertencem a uma "família". As aulas não relacionadas ao propósito do pacote não devem ir para lá.
Prós
Quando o autor do código original faz uma alteração - em particular, corrige um bug - então qualquer um pode facilmente tirar vantagem das alterações baixando uma nova versão da biblioteca, em vez de alterar algo por conta própria - e no caso de são os autores, faça alterações em pelo menos dois lugares de cada vez.

CRP - Common-reuse principle - Princípio de reutilização comum
As classes comumente usadas devem ser agrupadas
Prós
Melhor consistência e legibilidade do sistema


ADP - Acyclic dependencies principle
SDP - Stable-dependencies principle - Princípio das dependências estáveis
Um pacote variável não deve depender de um pacote difícil de mudar.
As dependências deste pacote devem ser mais estáveis ​​do que o próprio pacote.
Podemos aplicar o mesmo princípio às classes.
Prós
Reduz o efeito de uma reação em cadeia que força o código a ser modificado em vários outros lugares com uma única mudança

SAP - Stable-abstractions principle - princípio de abstrações estáveis
Um pacote estável (difícil de mudar) deve ser o mais abstrato possível (ou seja, operar principalmente em interfaces), de modo que sua estabilidade não impeça sua extensão.
Um pacote instável (fácil de mudar) deve ser o mais específico possível (ou seja, operar principalmente em implementações), pois sua instabilidade permite que você altere facilmente sua implementação específica.

CQS

High Cohesion & Low/Loose coupling & – High Cohesion & Low/Loose coupling &
Convention over Configuration (CoC)-Convention over Configuration Principle
SoC - Separation of Concerns
#Separação das responsabilidades
##Geralmente uma responsabilidade representa uma característica ou o comportamento de uma classe. O ato de separar um programa em responsabilidades discretas aumenta significativamente a reutilização de código, manutenção e testabilidade.


Design by Contract (DbC)-Design by Contract


Uma classe só deve ter uma única razão para mudar

Don’t make me think - Não me faça pensar

Easy to use right, hard to use wrong

Code for the Maintainer

Command / Query Separation

Avoid premature optimization

SOLID Principles:
• Single Responsibility - responsabilidade única
#A Classes deve ter um é somente um motivo para mudar.
###A responsabilidade pode ser definida como um motivo para a mudança,
###portanto, uma classe deve ter apenas um desses motivos e, portanto, uma responsabilidade.

• Open Closed Principle - aberto / fechado
#As Classes devem ser abertas para extensão e fechadas para modificação.
#Conte com abstração e polimorfismo.
#É fácil quebrar essa regra quando temos casos controlados por ify ou construção de switch.
Prós
Expansão do sistema mais fácil e estável.
Minimizamos a necessidade de modificar o código existente em muitos lugares quando adicionamos, por exemplo, outra instância de algo.

• Liskov Substitution - substituição de Liskov
#As classes no programa devem ser substituídas por suas subclasses sem afetar a correção do programa, ou seja, a classe que herda deve ser um bom equivalente da classe base.
#A subclasse não deve fazer menos do que a classe base. Portanto, ela deve sempre fazer mais.

• Interface Segregation - segregação de interface
#Muitas interfaces menores e específicas são melhores do que uma única interface genérica.
#Interfaces pequenas e compactas devem ser projetadas
##A classe não deve implementar uma interface através da qual viole o princípio de responsabilidade Única
##Uma classe que implementa uma interface não deve ser forçada a implementar métodos desnecessários, como costuma ser o caso com grandes iterfaces.
Prós
Melhor capacidade de reutilização de interfaces; às vezes, nem todos os métodos são necessários em uma interface "grande".

• Dependency Inversion -  inversão de dependência
# As classes de baixo nível não devem depender de classes de alto nível. 
#Ambos os grupos devem depender de suas abstrações.
#A abstração não deve depender de detalhes de implementação.
#Os detalhes da implementação devem depender da abstração
###Prós
####Minimizando dependências (acoplamento fraco)
####Flexibilidade - é mais fácil fazer alterações

IoC - Inversion of Control 

Regra de Escoteiro
##Sempre deixe para trás o código mais limpo do que você o encontrou.

Programe para interfaces, não para implementações
#A vantagem desse princípio é explorar o polimorfismo de modo que o objeto fique vinculado à abstração e diminua a quantidade de interdependências

Dependa de abstrações. Não dependa de classes concretas
#Também conhecido como Princípio da Inversão de Dependência

Encapsule o que varia
#Defende a idéia de separar as partes que variam e encapsulá-las 
#para que seja possível alterar ou estender essas partes 
#sem afetar as que não variam.

Dê prioridade à composição em relação à herança
#A utilização de composições proporciona interdependência entre os objetos
#e muito mais flexibilidade, 
#pois permite a alteração do comportamento durante o tempo de execução,
#desde que o objeto que estivermos compondo,
#utilize a interface de comportamento correta.

As classes devem estar abertas para a extensão, mas fechadas para modificações
#Permitir que as classes sejam facilmente estendidas para incorporar 
#um novo comportamento sem modificar o código existente

Acyclic Dependencies Principle (ADP)


GRASP

Minimize o acoplamento
Minimize as ligações entre pacotes / classes. Menos dependência é melhor.
Isso pode ser feito ocultando detalhes de implementação ou aplicando a Lei de Demeter
Prós
Isso reduz a chance de que a alteração do código dependendo de A não interrompa uma parte do código B.


Composição sobre herança
Prós
Isso reduz as dependências entre as classes
O uso de herança também torna mais fácil quebrar o princípio de substituição de Liskov

Encapsular quais mudanças
Os locais com maior probabilidade de serem alterados devem ser ocultados (encapsulados) na API.
Prós

Ele minimiza as modificações necessárias quando precisamos fazer uma mudança


 Robert Martin há três características importantes de um projeto ruim que devem ser evitadas :
Rigidez - É difícil mudar, porque cada mudança afeta muitas outras partes do sistema;
Fragilidade - Quando você faz uma alteração, partes inesperadas do sistema 'quebram' ;
Imobilidade - É difícil reutilizar noutra aplicação, porque não pode ser desembaraçada da aplicação atual;


Rigidez - O sistema foi feito de forma a ser duro de mudar, qualquer alteração provoca uma cascata de operações por todo o sistema;
Fragilidade - O sistema foi feito de forma que qualquer mudança feita o desestabiliza;
Imobilidade - O código foi feito de forma a ser difícil de ser reusado; nenhuma parte do sistema pode ser aproveitada em outro sistema;
Complexidade - O código foi feito com a aplicação de diversos padrões de projeto a um problemas simples;
Repetição de código desnecessária - O mesmo trecho de código esta esparramado por todo o sistema;
Manutenibilidade é uma característica inerente a um projeto de sistema ou produto, e se refere à facilidade, precisão, segurança e economia na  execução de açãoes de manutenção nesse sistema ou produto.




SRP - The Single Responsibility Principle
#Uma classe deve ter um, e somente um, motivo para mudar.
OCP - 	The Open Closed Principle
#Você deve ser capaz de estender um comportamento de uma classe, sem modificá-lo
LSP - The Liskov Substitution Principle
#As classes derivadas devem ser substituíveis por suas classes base.
ISP - The Interface Segregation Principle
#Muitas interfaces específicas são melhores do que uma interface geral
DIP - The Dependency Inversion Principle
#Dependa de uma abstração e não de uma implementação

Intimamente ligados ao principio DIP temos os princípio DI e o princípio IoC.

Big Ball of Mud (BBM) A grande bola de lama

