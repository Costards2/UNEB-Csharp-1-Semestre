\* Quetão 2 *\
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
\* Declarando vc mesmo as variaveis ( A questão não pediu mas...) *\
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
