# ProjetoEmEquipe
Projeto em equipe desenvolvido durante as aulas de Projeto de Interface Web do curso técnico em Informática para Internet do SENAI. A atividade envolveu o desenvolvimento de aplicações em C# e .NET e a gestão de repositórios no GitHub.

## 1. Calculadora Simples
Desenvolvido por: Guilherme Mauricio de Oliveira Damasceno [(@skazzi47)](https://github.com/skazzi47)

Descrição: Desenvolver uma calculadora que peça dois números e uma operação (+, -, *, /).

### O que foi utilizado
Biblioteca `System`, comando `ConsoleKeyInfo`, comando `Console.ReadKey`, estruturas de comparação e interpolação de variáveis.

### Etapas implementadas
- [x] Solicitar ao usuário para informar 2 números para que eles sejam usados na operação matemática que o usuário selecionar.
- [x] Solicitar ao usuário para escolher uma operação matemática apertando as seguintes teclas: "A" para Adição, "S" para Subtração, "M" para Multiplicação e "D" para Divisão.
- [x] Fazer a leitura da tecla que o usuário apertou.
- [x] Se o usuário tiver apertado alguma das teclas informadas à frente: "A", "S", "M" ou "D", realizar a operação matemática correspondente com os 2 números que o usuário informou.
- [x] Caso o usuário não tenha apertado alguma das 4 teclas citadas acima, pedir que ele aperte novamente alguma das teclas pedidas.
- [x] Retornar ao usuário o valor da operação matemática realizada pelo código.

### Backlog
- [ ] Realizar operações matemáticas.

### Conclusão
Geralmente, quando iríamos fazer estruturas condicionais em códigos de qualquer natureza, sempre selecionávamos o que queríamos fazer escrevendo alguma letra no CMD e apertávamos "Enter", porém eu quis fazer algo mais complexo e interessante. Assim veio a ideia de selecionar opções no código apenas apertando uma determinada tecla, seja ela qual for. Assim, fiz esse código usando os comandos `ConsoleKeyInfo` e `Console.ReadKey`, para que eles identifiquem quando a tecla desejada for pressionada e realize determinada ação dentro do código.

---

## 2. Jogo de Adivinhação de Números
Desenvolvido por: Ykaro Kaynã [(@kayna190)](https://github.com/kayna190)

Descrição: Criar um jogo onde o programa gera um número aleatório e o usuário tenta adivinhar. Dar dicas se o número é maior ou menor.

### O que foi utilizado
Biblioteca `System`, laços de repetição e validação de entrada.

### Etapas implementadas
- [x] Definir o intervalo de números (0 a 100).
- [x] Gerar um número aleatório que o usuário deve adivinhar.
- [x] Solicitar palpites do usuário até que o número correto seja adivinhado.
- [x] Validar a entrada do usuário para garantir que seja um número válido.
- [x] Fornecer feedback ao usuário se o palpite está muito baixo ou muito alto.
- [x] Informar ao usuário quantas tentativas foram necessárias para adivinhar o número correto.

### Backlog
- [ ] Permitir que o usuário escolha o intervalo de números.
- [ ] Adicionar um sistema de pontuação baseado no número de tentativas.
- [ ] Incluir uma opção para jogar novamente após acertar.

### Conclusão
Este jogo de adivinhação oferece uma experiência divertida e interativa, ilustrando conceitos fundamentais de C# como controle de fluxo e manipulação de entradas. Futuras melhorias podem aumentar a complexidade do jogo e a interatividade, tornando-o ainda mais envolvente.

---

## 3. Gerador de Senhas Aleatórias
Desenvolvido por: Lígia Souza [(@liGia-sz)](https://github.com/liGia-sz)

Descrição: Fazer um programa que gere uma senha aleatória com base em um conjunto de caracteres (letras e números) com um comprimento definido pelo usuário.

#### O que foi utilizado
Biblioteca `System`, laços de repetição e manipulação de strings com `StringBuilder`.

## Etapas implementadas
- [x] Exibir um título e solicitar ao usuário o comprimento desejado para a senha.
- [x] Validar a entrada do usuário, garantindo que seja um número positivo.
- [x] Gerar uma senha aleatória com base no comprimento especificado, utilizando um conjunto de caracteres (letras e números).
- [x] Exibir a senha gerada para o usuário.
- [x] Incluir mensagem de erro para entradas inválidas.

### Backlog
- [ ] Permitir que o usuário escolha incluir caracteres especiais na senha.
- [ ] Implementar uma opção para gerar múltiplas senhas de uma vez.
- [ ] Adicionar uma funcionalidade para verificar a força da senha gerada.

### Conclusão
Este gerador de senhas é uma ferramenta simples para quem busca criar senhas seguras. A implementação demonstra o uso de randomização e manipulação de strings em C#, proporcionando uma base sólida para futuras melhorias, como a inclusão de mais opções de personalização e segurança na geração de senhas.

---

## 4. Conversor de Temperatura
Desenvolvido por: Luiz Otávio [(@S-accarose)](https://github.com/S-accarose)

Descrição: Desenvolver um conversor de temperatura entre Celsius, Fahrenheit e Kelvin. O usuário escolhe o tipo de conversão.

### O que foi utilizado
Biblioteca `System` e estruturas de decisão para contorno de input inválido e impressão do resultado da conversão em console.

### Etapas implementadas
- [x] Solicitar que o usuário insira o valor a ser convertido.
- [x] Mensagem de erro para input inválido do usuário.
- [x] Escolha do tipo de conversão: Após inserir o valor a ser convertido, o usuário decide o tipo de conversão a ser realizada.
- [x] Impressão do resultado em console.

### Backlog
- [ ] Adicionar uma opção para converter múltiplas temperaturas de uma vez.
- [ ] Permitir que o usuário escolha a unidade de entrada e saída em vez de usar números.
- [ ] Implementar um sistema de histórico de conversões.

### Conclusão
Este conversor de temperatura é uma ferramenta útil para realizar conversões rápidas entre diferentes escalas térmicas. A implementação demonstra o uso de operações matemáticas básicas e manipulação de entradas em C#. Futuras melhorias podem expandir a funcionalidade e a usabilidade do programa.

---

## 5. Simulador de Lançamento de Dados
Desenvolvido por: Carol Duarte [(@duacarol)](https://github.com/duacarol)

Descrição: Simular o lançamento de um dado de 6 faces e exiba o resultado aleatório. Oferecer ao usuário a opção de lançar o dado várias vezes.

### O que foi utilizado
Biblioteca `System`, laços de repetição e controle de fluxo.

### Etapas implementadas
- [x] Gerador de números aleatórios para simular o lançamento de um dado.
- [x] Loop para permitir que o usuário jogue o dado repetidamente, com validação para respostas e opção para encerrar a aplicação.

### Backlog
- [ ] Exibir o histórico de resultados dos lançamentos.
- [ ] Jogar com dados de diferentes números de faces.

### Conclusão
Este simulador oferece uma forma descomplicada de jogar dados, permitindo que o usuário experimente a aleatoriedade em cada lançamento. A simplicidade do código torna-o fácil de entender e expandir, proporcionando uma base sólida para futuras melhorias e funcionalidades.

---

## 6. Calculadora de IMC
Desenvolvido por: Luiz Otávio [(@S-accarose)](https://github.com/S-accarose)

Descrição: O usuário insere seu peso e altura, e o programa calcula o IMC, dando uma categoria de saúde (baixo peso, normal, sobrepeso, etc.)

### O que foi utilizado
Biblioteca `System` e estruturas de decisão para contorno de input inválido e impressão do resultado do cálculo em console.

### Etapas implementadas
- [x] Solicitar ao usuário dois valores para o cálculo matemático.
- [x] Mensagem de erro para input inválido do usuário.
- [x] Impressão do resultado em console.

### Backlog
- [ ] Permitir que o usuário insira a altura em diferentes unidades (cm, m).
- [ ] Adicionar uma opção para calcular o IMC de várias pessoas em sequência.
- [ ] Implementar um sistema de histórico para armazenar os resultados.

### Conclusão
Este programa simples oferece uma maneira rápida e eficiente de calcular o IMC e entender a situação de peso de uma pessoa. A implementação utiliza conceitos fundamentais de C#, como validação de entradas e cálculos básicos. Futuras melhorias podem expandir a funcionalidade e a usabilidade do programa, tornando-o mais abrangente e interativo.

---

## 7. Decisão de Almoço
Desenvolvido por: Carol Duarte [(@duacarol)](https://github.com/duacarol)

Descrição: O programa gera opções de restaurantes ou pratos pra o usuário escolher, ou gera uma escolha aleatória de almoço se o usuário estiver indeciso.

### O que foi utilizado
Biblioteca `System`, classe `List<T>`, geração de números aleatórios com `Random` e estruturas de repetição.

### Etapas implementadas
- [x] Estruturas de dados para armazenar opções de restaurantes e seus pratos correspondentes.
- [x] Menu de opções:
    - [x] *Escolher restaurante*: O usuário escolhe um restaurante e, em seguida, escolhe um prato daquele restaurante.
    - [x] *Escolher prato*: O usuário escolhe um prato único, e o programa lista os restaurantes que oferecem esse prato.
    - [x] *Estou indeciso(a), escolha por mim*: O programa escolhe aleatoriamente um restaurante e um prato para o usuário.
- [x] Loop para permitir que o usuário faça novas escolhas, com validação para respostas e opção para encerrar a aplicação.

### Backlog
- [ ] Adicionar opções de filtro por tipo de prato (vegano, picante etc.) e por faixa de preço.
- [ ] Permitir ao usuário adicionar seus próprios restaurantes e pratos.
- [ ] Criar um sistema de classificação de pratos e restaurantes.

### Conclusão
Este aplicativo foi desenvolvido para simplificar a escolha de refeições, especialmente em momentos de indecisão. O objetivo é possibilitar os usuários a explorarem diferentes opções de restaurantes e pratos. Com sugestões aleatórias, o aplicativo ainda oferece uma alternativa interessante para quem não sabe o que escolher.

---

## 8. Cronômetro Simples
Desenvolvido por: Guilherme Mauricio de Oliveira Damasceno [(@skazzi47)](https://github.com/skazzi47)

Descrição: Desenvolver um cronômetro onde o usuário define quantos segundos o cronômetro deve rodar.

### O que foi utilizado
- Biblioteca `System.Diagnostics`
- Comando `Stopwatch stopwatch = new stopwatch();`
- Comando `stopwatch.Start();`
- Comando `stopwatch.Stop();`
- Comando `TimeSpan tempoDecorrido = stopwatch.Elapsed;`

### Etapas implementadas
- [x] Chamar o comando `Stopwatch` para medir o tempo decorrido de maneira precisa.
- [x] Pedir para o usuário pressionar a tecla "Enter" para que o cronômetro comece a contar o tempo.
- [x] Pedir para o usuário pressionar a tecla "Enter" para que o cronômetro pare de contar o tempo.
- [x] Chamar o comando `TimeSpan tempoDecorrido = stopwatch.Elapsed;` que fará a função de registrar o tempo passado durante o funcionamento do cronômetro.
- [x] Informar ao usuário quanto tempo o cronômetro registrou.

### Backlog
- [ ] Pressionar a tecla "Enter" para começar a cronometrar
- [ ] Pressionar a tecla "Enter" para parar a cronometrar
- [ ] Informar o tempo passado nesse processo.

### Conclusão
Este código foi feito para fazer a função de um cronômetro e registrar quanto tempo se passou desde sua ativação até seu desligamento por parte do usuário ao qual o está utilizando.