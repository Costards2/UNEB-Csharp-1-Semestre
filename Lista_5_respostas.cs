/* Questão 1 */

using System;
class equacaodosegundograu {
  static double raizpositiva(double a, double b, double delta){
    return (-b + Math.Sqrt(delta)) / (2 * a);
  }
  static double raiznegativa(double a, double b, double delta){
    return (-b - Math.Sqrt(delta)) / (2 * a);
  }
  static void Main() {
    double a, b, c, delta, x1, x2;  
    Console.WriteLine("escreva o valor de a, b e c");
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    c = double.Parse(Console.ReadLine());
    
    if (a == 0){
        Console.WriteLine("o valor de a não pode ser 0\nEscreva um novo valor");
        a = double.Parse(Console.ReadLine());
    }
    
    delta = (b * b) - (4 * a * c);
    
    if (delta > 0){
        x1 = raizpositiva(a, b, delta);
        x2 = raiznegativa(a, b, delta);
        Console.WriteLine($"Status 2, o valor de x1 é {x1} e o valor de x2 é {x2}");
    }else if(delta == 0){
        x1 = raizpositiva(a, b, delta);
        Console.WriteLine($"Status 1, o valor de x1 é {x1} ");
    }else{
        Console.WriteLine($"Status 0, o valor de delta é negativo");
    }
    
    
  }
}

/* Quetão 2 */

using System;
class questao2 {
  static void Main(string[] args)
  {

       int[] array = new int [4];
       int n = 4;
       
       for(int k = 0; k < 4; k++){
           Console.WriteLine("Digite o numero:");
           array[k] = int.Parse(Console.ReadLine());
       }
       
       for(int i = 0; i < n; i++)
          Console.Write("{0}\t", array[i]);
  
       for(int i = 0; i < n-1; i++){
         for(int j = 0; j < n-1; j++){
           if(array[j] > array[j+1]){
             int flag = array[j];
             array[j] = array[j+1];
             array[j+1] = flag;
           }/*if*/
         }/*for*/
        }/*for*/  
  
    Console.Write("\n");   
  
     for(int i = 0; i < n; i++)
          Console.Write("{0}\t", array[i]);     
         
  }
}

/* Declarando vc mesmo as variaveis ( A questão não pediu mas...) */

using System;
class questao2 {
  static void Main(string[] args)
  {

       int[] array = {90, 70, 50, 80, 60, 85, 1 , 2, 3, 4};
       int n = 10;
       
       for(int i = 0; i < n; i++)
          Console.Write("{0}\t", array[i]);
  
       for(int i = 0; i < n-1; i++){
         for(int j = 0; j < n-1; j++){
           if(array[j] > array[j+1]){
             int flag = array[j];
             array[j] = array[j+1];
             array[j+1] = flag;
           }/*if*/
         }/*for*/
        }/*for*/  
  
    Console.Write("\n");   
  
     for(int i = 0; i < n; i++)
          Console.Write("{0}\t", array[i]);     
         
  }
}

/* Questão 3 */

using System;
class questão3 {
  static bool Data(int dia, int mes){
    if(dia <= 31 && mes <= 12){
        return true;
    }else{
        return false;
    }
  }
  static void Main() {
    int dia, mes, ano;  
    bool validacao;
    Console.WriteLine("Digite o dia");
    dia = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o mês");
    mes = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano");
    ano = int.Parse(Console.ReadLine());
  
    validacao = Data(dia, mes);
    
    if(validacao == true){
        Console.WriteLine("Data válida");
    }else{
        Console.WriteLine("Data inválida");
    }
  }
}

/* Questão 4 */

using System;
class HelloWorld {
  static int fatorial(int numero){
    int produto = numero;
    for (int i = numero - 1; i >= 1; i--){
        
        produto = produto * i;
        
    }
    return produto;
  }
  static void Main() {
    int numero, i;
    int resultado = 0;  
    i = 0;
    while (i <= 15){
        numero = i;
        resultado = fatorial(numero);
        Console.WriteLine($"O fatorial de {i} é {resultado}"); //Dá para fazer um for para "printar" o resultado, talvez ficasse mais organizado        
        i++;
        
    }
  }
}


/* Questão 5 */

using System;
class HelloWorld {
  static double fatorial(double Base, double expoente){
    double calculo;
    calculo = Math.Pow(Base, expoente);
    return calculo;
  }
  static void Main() {
    double i, j;
    double resultado = 0;  
    i = 2;
    while( i <= 20){
        j=1;
        while (j <= 10){
            resultado = fatorial(i, j);
            Console.WriteLine($"{i} elevado a {j} e igual a {resultado}");        
            j++;
        }
        i++;
        
    }
  }
}

/* Questão 6 */

using System;
class relogio {
  static int segundos(int segundos){
          segundos++;
          return segundos;
    }
  static int minutos(int minutos){
          minutos++;
          return minutos;
    }
  static int horas(int horas){
            horas++;
            return horas;
    }
  static void Main() {
    int hora = 0, minuto = 0, segundo = 0;  
    do{
        if(segundo < 60){
            segundo = segundos(segundo);
        }
        if(segundo == 60){
            segundo = 0;
            minuto = minutos(minuto);
        }
        if(minuto == 60){
            segundo = 0;
            minuto = 0;
            hora = horas(hora);
        }
        Console.WriteLine($"{hora}:{minuto}:{segundo}"); // O programa vai rodar frenéticamente mas está certo
    }while(hora!=24);
  }
}

/* Questão 7 */

using System;  
class questão7
{  
    static bool confirmacoes(int numero){
         for(int d = 2; d <= numero/2; d++)
            {
             if(numero % d == 0){
                return false;
            }
        }return true;
    }   
    
    public static void Main()
{
	int n, numero, d, divisores;
	bool confirmacao;
	
    Console.Write("diga até que numero você deseja ir : ");
    numero = int.Parse(Console.ReadLine()); 	
  
    for(n = 1; n <= numero; n++)
       {
         divisores = 0;

         for(d = 2; d <= n/2; d++)
            {
             if(n % d == 0){
                divisores++;
                break;
            }
        }
        
         if(divisores == 0 && n != 1)
            Console.Write("{0} ",n);
    }
    confirmacao = confirmacoes(numero);
    Console.WriteLine(" ");
    if(confirmacao == true){
        Console.WriteLine($"{numero} é primo");
    }else{
        Console.WriteLine($"{numero} não é primo");
    }
  } 
}

/* Questão 8 */

using System;
class questão8 {
    static float serie(int n){
        int j = 1;
        float resposta = 0;
        int i = 1;
        
        for (i = 1; i <= n; i++){
            if(i == 1){
                resposta = i/n;
            }else{
                if (i % 2 == 0){
                    resposta = resposta - (i/(n - j));
                    j++;
                }else{
                    resposta = resposta + (i/(n - j));
                    j++;
                }
            }
        }
        return resposta;
    }
    
    static void Main() {
        int n;
        float resposta=0;
        
        Console.WriteLine("Escreva um numero inteiro");
        n = int.Parse(Console.ReadLine());
        resposta = serie(n);
        Console.WriteLine(resposta);      

        
    }
}

/* Questão 9 */

using System;
class HelloWorld {
   static string entrada(string nome){
        nome = Console.ReadLine();
        return nome;
  }
  static float entrada2(float peso){
        peso = float.Parse(Console.ReadLine());
        return peso;
  }
  static void Main() {
    string[] nome = new string[10];//{"a", "b", "c","d","f","g","h","i","j","k"};
    string[] sexo = new string[10];//{"f", "m", "m","m","m","f","f","f","m","f"};
    float[] altura  = new float[10];//{ 1.80d , 2.00d, 1.60d, 1.70d, 1.50d, 1.80d, 1.80d, 1.60d, 1.55d, 1.65d};
    float[] peso  = new float[10];//{ 40.5d, 60.6d, 40.3d, 40.4d, 80.4d, 80.5d, 90.5d, 50.9d, 80.8d, 40.6d};
    float altura2 = 0, peso2 = 0;
    string nome2 = "", sexo2 = "";
    int i = 0;
    for(i = 0; i<10; i++){
        Console.WriteLine("escreva o nome, sexo, altura e peso da pessoa");
        nome2 = entrada(nome2);
        nome[i] = nome2;
        sexo2 = entrada(sexo2);
        sexo[i] = sexo2;
        altura2 = entrada2(altura2);
        altura[i] = altura2;
        peso2 = entrada2(peso2);
        peso[i] = peso2;
    }
    float somap = 0;
    float somaa=0;
    float mediap = 0;
    float mediaa= 0;
    float sm = 0, sf = 0;
    for(i = 0; i<4; i++){
        if(sexo[i] == "f"){
            somap = somap + peso[i];
        }
        if(sexo[i] == "m"){
            somaa = somaa + altura[i];
        }
        if(sexo[i] == "m"){
            sm++;
        }else{
            sf++;
        }
    }
    mediap = somap / sf;
    mediaa = somaa / sm;
    float maior = 0;
    float maiora = 0;
    string maiorp = "a";
    string maioral = "b";
    for(i = 0; i<4; i++){
        
        if(peso[i] > maior && (sexo[i] == "f")){
            maiorp = nome[i];
            maior = peso[i];
        }
        if(altura[i] > maiora && (sexo[i] == "m")){
            maioral = nome[i];
            maiora = peso[i];
        }
    }
    string mediaps, mediaas;
    mediaps = Convert.ToString(mediap);
    mediaas = Convert.ToString(mediaa);

    string[] saidas = new string[4]{mediaps, mediaas, maiorp, maioral};
    Console.WriteLine($"a media da altura dos homens: {saidas[1]}\na media do peso das mulheres{saidas[0]}\no homem mais alto é {saidas[3]}\na mulher mais gorda é {saidas[2]}");
  }
}


