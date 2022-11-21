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

/* Questão 4 */ //ainda fazendo
using System;
class q4 {
  static void Main() {
    
    float[] vetor1 = new float[3]; //A questao pede vetores de 10 valore mas para fazer o teste mais rapido usarei 3
    float[] vetor2 = new float[3];
    //float[] vetor3 = new float[3]{};
    
    int i = 0;
    
    Console.WriteLine("SOMENTE VALORES EM ORDEM CRESCENTE!!!");
    for(i = 0; i < 3; i++)
    {
    Console.WriteLine("Digite seus 3 valores do vetor 1, sendo esse o seu {0}° valor ", i + 1);
    vetor1[i] = float.Parse(Console.ReadLine());
        if(vetor1[i] < vetor1[i+1])
        {
          Console.WriteLine("Os valores não estão em oredem crescente, digite novamente.");
          vetor1[i] = float.Parse(Console.ReadLine());
        }            
    }
    for(i = 0; i < 3; i++)
    {
    Console.WriteLine("Digite seus 3 valores do vetor 2, sendo esse o seu {0}° valor ", i + 1);
    vetor2[i] = float.Parse(Console.ReadLine());
        if(vetor2[i] < vetor2[i+1])
        {
          Console.WriteLine("Os valores não estão em oredem crescente, digite novamente.");
          vetor2[i] = float.Parse(Console.ReadLine());
        }        
      }
    }
  }

/* Questão  5 */
using System;
class q5 {
  static void Main() {
      
    int[] vetor = new int[10];
    int i = 0;
    int N = 0;
    int existe = 0;
    
    for(i = 0; i < 10; i++)
    {
        Console.WriteLine("Digite seus 10 valores do vetor, sendo esse o seu {0}° valor: ", i + 1);
        vetor[i] = int.Parse(Console.ReadLine());
    }
    
    Console.WriteLine("\nDigite o valor N para verificar se ele se encontra no vetor: ");
    N = int.Parse(Console.ReadLine());
    
    for(i = 0; i < 10; i++)
    {
        if( vetor[i] == N )
        {
            Console.WriteLine("\nO valor {0} foi encontarndo na posição {1}° do vetor.", N, i + 1);
            existe++;
        }
    }
    
    if (existe == 0)
    {
        Console.WriteLine("O valor não foi encontrado dentro do vetor.");
    }
  }
}

/* Questão 6 */ //ainda sendo feit
//#define N 5
using System;
class q5 {
  static void Main() {
     
    int i = 0, j = 0, N = 5; 
    int[] vetor1 = new int[N]; // A questão fala até 10 numeros, por isso usarei 5
    int[] vetor2 = new int[N];
    int[] vetor3 = new int[N];
    
    for(i = 0; i < N; i++)
    {
        Console.WriteLine("Digite seus {0} valores do vetor, sendo esse o seu {1}° valor: ", N,  i + 1);
        vetor1[i] = int.Parse(Console.ReadLine());
        
        vetor3[i] = vetor1[i];
    }
    
    for(i = 0; i < N; i++)
    {
        for(j = 0; j < N; j++)
        {
            if( vetor1[i] == vetor3[j] )
            {
                vetor3[j] = 0;
            }
        }
        
        vetor2[i] = vetor3[i];
        
        Console.WriteLine("{0}\t", vetor2[i]);
        
    }
  }
}

