using System;
class HelloWorld {
  static void Main() {
    
        int i, j, m, n;
        int[,] a = new int[20, 20];
        
        Console.WriteLine("Coloque a quantidade de linhas :"); //Maximo 20, defini lá em cima
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a quantidade de colunas :"); //Maximo 20
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque os elementos 1 por 1 :"); //lembrando que é por linha, depois de completar a linha ele vai para proxoma coluna
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
            
            int ehidentidade = 1;
            for (i = 1; i <= m; i++)
                {
                    for (j = 1; j <= n; j++)
                    {
                        if ((i == j) && (a[i, j] != 1)){
                            ehidentidade = 0;
                        }
                        else if ((i != j) && (a[i, j] != 0)){
                            ehidentidade = 0;
                        }
                        }
                    }
                        if (ehidentidade == 1){
                            Console.WriteLine("Sua matriz é uma matriz identidade");
                        }
                        else{
                        Console.WriteLine("Sua matriz não é quadrada, então não possui diagonal, logo não é uma matriz identidade");
                        }
            }
        }
