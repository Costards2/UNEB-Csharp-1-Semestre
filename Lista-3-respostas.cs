/* Questão 1 */
        using System;

namespace myApp
{ 
  class questao1
  {
    static void Main()
    {
        int num1, num2, num3, arit, soma, produto;
        
        Console.WriteLine ("Digite seu Primeiro Numero Inteiro : ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Digite seu Segundo Numero Inteiro : ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Digite seu Terceiro Numero Inteiro : ");
        num3 = int.Parse(Console.ReadLine());
        
        arit = (num1 + num2 + num3)/ 3;
        soma = num1 + num2 + num3;
        produto = num1 * num2 * num3;
        
        Console.WriteLine("Aritimética: " +arit);
        Console.WriteLine("Soma: " +soma);
        Console.WriteLine("Produto: " +produto);     
    }
  }
}

/* Questão 2 */
        
using System;

namespace myApp
{ 
  class questao2
  {
    static void Main()
    {
        double inscricao, classe, shorasnormais, shorasextras;
        int horas, horasextras;
        string nome; 
        
        Console.WriteLine ("Inscricao : ");
        inscricao = int.Parse(Console.ReadLine());
        Console.WriteLine ("Classe : ");
        classe = int.Parse(Console.ReadLine());
        Console.WriteLine ("Horas Normais : ");
        horas = int.Parse(Console.ReadLine());
        Console.WriteLine ("Horas Extras : ");
        horasextras = int.Parse(Console.ReadLine());
        Console.WriteLine ("Nome : ");
        nome = (Console.ReadLine());
        
        shorasnormais = (5 * horas) * 1.3;
        shorasextras = (shorasnormais * 0.3) * horasextras;
        double salariobruto = (shorasnormais * 0.3) + shorasnormais;
        double INSS = salariobruto * 0.11;
        double salarioliquido = salariobruto - INSS; 
        
        Console.WriteLine("***********FICHA***********\r");
        Console.WriteLine("INCRICAO: \r" +inscricao);
        Console.WriteLine("\rNOME: \r" +nome);
        Console.WriteLine("\rSALARIO HORAS NORMAIS: \r" +shorasnormais); 
        Console.WriteLine("\rSALARIO HORAS EXTRAS: \r" +shorasextras);
        Console.WriteLine("\rDEDUCAO DO INSS: \r" +INSS);
        Console.WriteLine("\rSALARIO LIQUIDO: \r" +salarioliquido);     
    }
  }
}
