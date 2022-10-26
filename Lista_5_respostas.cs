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
class HelloWorld {
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



