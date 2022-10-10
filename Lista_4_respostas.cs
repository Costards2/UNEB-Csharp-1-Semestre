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
        
