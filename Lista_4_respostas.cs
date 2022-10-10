/* Lista 4 */
/* Questão 1 */
                          
using System;
class lista4_questao1 {
  static void Main() {
    
    int a, b, i;
    int soma = 0;
    
    Console.WriteLine("Digite o numero (a) do intervalo :");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o numero (b) do intervalo :");
    b = int.Parse(Console.ReadLine());
    
    for(i = a; i <= b; i++){
        
        if( i % 2 != 0){
          soma = soma + i;
          Console.WriteLine(soma);
            
        }
    }
    
    Console.WriteLine("A soma de todos os numeros impares no intervalo é : " + soma);
 }
}
  
/* Quetão 2 */
                        
using System;
class lista4_questao2 {
  static void Main() {
    
    int N, i;
    int tabuada;
    
    Console.WriteLine("Digite o numero (N) do intervalo :");
    N = int.Parse(Console.ReadLine());
    
    for(i = 0 ; i <= 10; i++){
        
        tabuada = N * i;
          Console.WriteLine($"{N} x {i} = {tabuada}");
  }
 }
}

/* Questão 3 */
                       
using System;
class lista4_questao3 {
  static void Main() {
    
    int N;
    int menor = 1000000; 
    
    
    Console.WriteLine("Digite a qauntidade de numeros do conjunto :");
    N = int.Parse(Console.ReadLine());
   
    for( int i = 1; i <= N; i++){
    
    Console.WriteLine($"Digite o seu numero ({i}) :");
    int numero = int.Parse(Console.ReadLine());
    
    if(numero < menor){
        menor = numero;
    }
  }
  Console.WriteLine(" O menor valor do conjunto é: " + menor);
 }
}
                      
/* Questão 4 */
                        
using System;
class lista4_questao4 {
  static void Main() {
    
    int N, Nlista, i;
    
    Console.WriteLine("Digite seu numero :");
    N = int.Parse(Console.ReadLine());
    
    for(i = Nlista ; i != N;){
    
    Console.WriteLine("Digite o numero da lista :");
    Nlista = int.Parse(Console.ReadLine());
    
    if(Nlista == N){
        Console.WriteLine($"O numero {Nlista} é igual ao primeiro número lido!");
        
        }else{ 
            ($"O numero {Nlista} não é igual ao primeiro número lido!");

      }
    }
  }
}
  
/* Questão 5 */

  using System;
class questao5 {
  static void Main() {
  int impares = 0, pares = 0;
  float numero = 0;
  Console.WriteLine(&quot;diga os numeros presentes no seu conjunto\npara parar de adicionar ao
  conjunto digite -1&quot;);
  while (numero != -1){
  Console.WriteLine(&quot;escreva um numero inteiro&quot;);

  numero = float.Parse(Console.ReadLine());
  if(numero == -1){
  break;
  }
  else if(numero % 2 == 0){
  pares++;
    }else{
      impares++;
  }
}
Console.WriteLine($&quot;a quantidade de numeros pares é {pares}&quot;);
Console.WriteLine($&quot;a quantidade de numeros impares é {impares}&quot;);
  }
}

/* Questão 6 */

using System;
class questao5 {
  static void Main() {

    int numero, i;
    Console.WriteLine(&quot;digite o numero para saber o seu fatorial&quot;);
    numero = int.Parse(Console.ReadLine());
    int produto = numero;
    for (i = numero - 1; i &gt;= 1; i--){
    produto = produto * i;
    }
    Console.WriteLine($&quot;o fatorial de {numero} é {produto}&quot;);
    }
  }

/* Questão 7 */ 

using System;
class questao5 {
  static void Main() {

  int numeros, i;
  int sequencia = 1, soma = 1, sequencia2 = 0;

  Console.WriteLine(&quot;escreva a quantidade de numeros da sequencia de Fibonacci que vc deseja saber&quot;);
  numeros = int.Parse(Console.ReadLine());
  for (i = 1; i &lt;= numeros; i++){
    Console.WriteLine(soma);
    soma = sequencia + sequencia2;
    sequencia2 = sequencia;
    sequencia = soma;
    }
  }
}

/* Questão 8 */

using System;
class shopping {
  static void Main() {

    int idade, i = 0, objetivo, quantidadesf = 0, quantidadesm = 0;
    int compras = 0, servicos = 0, lazer = 0, alimentacao = 0, totalobjetivo;
    float porcentagem;
    string nome, sexo;

    Console.WriteLine(&quot;Bem vindo ao shopping!\nPor favor responda nossa pesquisa!&quot;);
    Console.WriteLine(&quot;obs:para acabar com a pesquisa escreva fim ao inves de seu nome&quot;);
    while (i != 1){
    Console.WriteLine(&quot;escreva seu nome&quot;);
    nome = Console.ReadLine();
    if(nome == &quot;fim&quot;){
    break;
    }

    Console.WriteLine(&quot;escreva sua idade&quot;);
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine(&quot;escreva seu sexo(masculino ou feminino)&quot;);
    sexo = Console.ReadLine();
    if(sexo == &quot;masculino&quot;){
      quantidadesm++;
        }else{
           quantidadesf++;
        }

    Console.WriteLine(&quot;escreva o objetivo da visita&quot;);
    Console.WriteLine(&quot;010 Compras\n020 Serviços (Banco, correio,etc.)\n030 Lazer (Cinema, jogos,etc.)\n040 Alimentação (restaurantes e lanchonetes)&quot;);
    objetivo = int.Parse(Console.ReadLine());

    if(objetivo == 010){
    compras++;
      }else if(objetivo == 020){
        servicos++;
          }else if(objetivo == 030){
            lazer++;
              }else if(objetivo == 040){
                alimentacao++;
  }
}
    totalobjetivo = compras + servicos + lazer + alimentacao;
    porcentagem = (servicos * 100)/totalobjetivo;

    Console.WriteLine($&quot;a porcentagem de pessoas que escolheu serviços é {porcentagem}%&quot;);
    if(quantidadesf &gt; quantidadesm){
       Console.WriteLine(&quot;o numero de mulheres frequentando o shopping foi maior que o de homens&quot;);
      }else{
        Console.WriteLine(&quot;o numero de homens frequentando o shopping foi maior que o de mulheres&quot;);
  }
 }
}

/* Questão 9 */

using System;
class livraria {
  static void Main() {

    int tipo, quantidades1 = 0, quantidades2 = 0, quantidades3 = 0, i = 0;
    double mficcao = 0, mromance = 0, maventura = 0, mtotal;
    double porcentagem;
    string sexo;

    Console.WriteLine(&quot;Bem vindo a livraria!\nPor favor responda nossa pesquisa!&quot;);
    Console.WriteLine(&quot;obs:para acabar com a pesquisa escreva 0 no tipo de livro&quot;);

    while (i != 1){
    Console.WriteLine(&quot;tipo de livro\n1 - Ficção \n2 – Romance \n3 –Aventura&quot;);
    tipo = int.Parse(Console.ReadLine());

    if(tipo == 0){
    break;
      } else if(tipo == 1){
        quantidades1++;
          }else if(tipo == 2){
            quantidades2++;
              }else if(tipo == 3){
                 quantidades3++;
}

    Console.WriteLine(&quot;escreva seu sexo\nm-masculino\nf-feminino)&quot;);
    sexo = Console.ReadLine();

    if((sexo == &quot;m&quot; || sexo == &quot;M&quot;) &amp;&amp; tipo == 1){
    mficcao++;
      }else if((sexo == &quot;m&quot; || sexo == &quot;M&quot;) &amp;&amp; tipo == 2){
        mromance++;
          }else if((sexo == &quot;m&quot; || sexo == &quot;M&quot;) &amp;&amp; tipo == 3){
            maventura++;
  }
}
    mtotal = maventura + mromance + mficcao;
    porcentagem = (mromance * 100)/mtotal;

    Console.WriteLine($&quot;a porcentagem de pessoas do sexo masculino que compra o tip0 romance é {porcentagem}%&quot;);

    if(quantidades1 &gt; quantidades2 &amp;&amp; quantidades1&gt;quantidades3){
    Console.WriteLine(&quot;o numero de livros de ficção vendidos foi maior que os outros tipos&quot;);
      }else if(quantidades2 &gt; quantidades1 &amp;&amp; quantidades2 &gt; quantidades3){
        Console.WriteLine(&quot;o numero de livros de romance vendidos foi maior que os outros tipos&quot;);
          }else if(quantidades3 &gt; quantidades1 &amp;&amp; quantidades3 &gt; quantidades2){
            Console.WriteLine(&quot;o numero de livros de aventura vendidos foi maior que os outros tipos&quot;);
              }else{
                Console.WriteLine(&quot;todos os tipos venderam igualmente&quot;);
    }
  }
}

/* Questão 10 */

using System;
class relogio {
  static void Main() {

    int horas = 0, minutos = 0, segundos = 0, i = 0;
    
    do {
    segundos++;
      if (segundos == 60){
        minutos++;
        segundos = 0;
}
    if (minutos == 60){
    horas++;
    minutos = 0;
    segundos = 0;
}
    Console.WriteLine($&quot;{horas}:{minutos}:{segundos}&quot;);
    }while(horas != 24);
  }
}
