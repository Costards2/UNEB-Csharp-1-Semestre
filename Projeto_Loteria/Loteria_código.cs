using System;
public class HelloWorld {
    
    static void Introducao ()
    {
        Console.WriteLine("Para cada jogo, selecione:");
        Console.WriteLine("0 para apostar na vitória da primeira equipe;");
        Console.WriteLine("1 para apostar em empate;");
        Console.WriteLine("2 para apostar na vitória da segunda equipe.");
    }
    static void EntradaAposta (int[,] aposta)
    {
      int s, k=0; //s é número selecionado pelo usuário
        while (k<13)
        {
            Console.WriteLine("Para o jogo "+(k+1));
            Console.WriteLine("Selecione o número correspondente para apostar.");
            s=int.Parse(Console.ReadLine());
            if ((s>=0)&&(s<=2))
            {
                aposta[k,s]=1;  
                k++;
            }
            else Console.WriteLine("Seleção inválida.");
        }
        
        Console.WriteLine("Sua aposta:");
        for (int q = 0; q < 13; q++)
        {
        for (int w = 0; w < 3; w++)
            {
                Console.Write("\t{0}", aposta[q, w]);
            }
            Console.WriteLine();
        }
    
        
    }
    
    static void Resultado (int [,] resultado)
    {
        Random random = new Random();
        
        for (int y = 0; y< 13; y++) 
        {
        int posicao = random.Next (0,3);
        resultado [y,posicao] = 1;
        }
        
        Console.WriteLine("\nResultado:");
        for (int q = 0; q < 13; q++)
            {
                for (int w = 0; w < 3; w++)
                {
                    Console.Write("\t{0}", resultado[q, w]);
                }
            Console.WriteLine();
        }
        
        
    }
    
    static void Comparação (int[,] aposta, int[,] resultado)
    {
        int i=0, j=0, contador=0;
        while(i<13)
        {
            while (j<3)
            {
                if ((aposta[i,j]==1) && (resultado[i,j]==1)) contador++;
                j++;
            } 
            i++;
            j=0;
        }
        Console.WriteLine("Voçê acertou o resultado de {0} jogo(s).",contador);
    }
    
    
  static void Main() 
  {

    int[,] aposta=new int[13,3], resultado=new int[13,3]; //{{1,0,0},{0,0,1},{0,1,0},{1,0,0},{1,0,0},{1,0,0},{0,1,0},{0,1,0},{0,0,1},{0,0,1},{0,1,0},{0,1,0},{1,0,0}};
    
    Introducao();//Dá as instruções para o usuário
    EntradaAposta (aposta);//Lê as apostas do usuário
    Resultado(resultado);//Cria um resultado randômico
    Comparação (aposta, resultado);//Compara a aposta com o resultado e imprime os acertos
  }
}
