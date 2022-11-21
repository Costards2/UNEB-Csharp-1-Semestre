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
