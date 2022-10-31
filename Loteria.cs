using System;
class ApostaLoterica {
  static void Main() {
      
     int i=0, j=0, k=0, selecao, contador=0; 
     int[,] aposta=new int[13,3], resultado=new int[13,3];//{{1,0,0},{0,0,1},{0,1,0},{1,0,0},{1,0,0},{1,0,0},{0,1,0},{0,1,0},{0,0,1},{0,0,1},{0,1,0},{0,1,0},{1,0,0}};
     Random random = new Random();
     //o professor disse que a gente poria usar o resultado que está na lista, contudo decicir usar o random, mas o código funciona sem ele
    
    for (k = 0; k< 13; k++) {
                int posicao = random.Next (0,3);
                    resultado [i,posicao] = 1;
    }
    
   Console.WriteLine("Para cada jogo, selecione:");
   Console.WriteLine("0 para apostar na vitória da primeira equipe;");
   Console.WriteLine("1 para apostar em empate;");
   Console.WriteLine("2 para apostar na vitória da segunda equipe.");
   
  //Entrada de apostas
   while(i<13)
    {
      Console.WriteLine("Para o jogo "+(i+1));
      Console.WriteLine("Selecione o número correspondente para apostar.");
      selecao=int.Parse(Console.ReadLine());
      if ((selecao>=0)&&(selecao<=2)) //Caso o usuário coloque outro número, ele dá inválido
      {
        aposta[i,selecao]=1;  
        i++;
      }
      else Console.WriteLine("Seleção inválida.");
    }
    
    //Comparação com o resultado
    i=0;
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
    // O programa só imprime o número de acertos
  
  }
 }
