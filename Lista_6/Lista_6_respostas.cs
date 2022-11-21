/* Questão 1 */
using System;
class q1 {
  static void Main() {
    
    float[] valor = new float[8];
    int i = 0;
    float multiplicaçao = 1;
    
    for(i = 0; i < 8; i++){
    Console.WriteLine("Digite seus 8 valores, sendo esse o seu {0}° valor ", i + 1);
    valor[i] = float.Parse(Console.ReadLine());
    
    multiplicaçao = multiplicaçao * valor[i];
    }
    Console.WriteLine($"O resultado das multiplicaçoes é: {multiplicaçao} ");
  }
}

/* Questão 2 */
using System;
class q2 {
  static void Main() {
    
    float[] vetorA = new float[8];
    float[] vetorB = new float[8];
    float[] vetorC = new float[8];
    int i = 0;
    float soma = 0;
    
    for(i = 0; i < 8; i++)
    {
    Console.WriteLine("Digite seus 8 valores do vetor A, sendo esse o seu {0}° valor ", i + 1);
    vetorA[i] = float.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite seus 8 valores do vetor B, sendo esse o seu {0}° valor ", i + 1);
    vetorB[i] = float.Parse(Console.ReadLine());
    
    soma = vetorA[i] + vetorB[i];
    vetorC[i] = soma;
   
    }
    
    for(i = 0; i < 8; i++)
    {
    Console.WriteLine("Os valores do vetor C são: {0} ", vetorC[i]);
    }
  }
}

/* Questão 3 */
using System;
class q3 {
  static void Main() {
    
    float[] salarios = new float[5]; //São 50 funcionario na questao, mas para o código não ficar imenso usarei 5
   
    int i = 0;
    float media = 0;
    float soma = 0;
    int acima = 0;
    for(i = 0; i < 5; i++)
    {
    Console.WriteLine("Digite o valor do salario do seu {0}° funcionario ", i + 1);
    salarios[i] = float.Parse(Console.ReadLine());
    
    soma = soma + salarios[i];
    }
    
    media = soma / 5;
    
     for(i = 0; i < 5; i++)
    {
        if( salarios[i] > media)
        {
        acima++;
        }
    }
    
    Console.WriteLine($"Existem {acima} funcionários que ganham salário acima da média!");
    
  }
}
