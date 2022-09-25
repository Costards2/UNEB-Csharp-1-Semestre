/* Questão 4*/
using System;

public class cronometro
{
    public static void Main(string[] args)
    {
        int horas, minutos, segundos, resultado;
        
        Console.WriteLine ("Digite a quantidade de Horas");
        horas = int.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a quantidade de Minutos");
        minutos = int.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a quantidade de Segundos");
        segundos = int.Parse(Console.ReadLine());
        
        resultado = (horas * 3600) + (minutos * 60) + segundos;
        
        Console.WriteLine ("Total do tempo em segundos: " + resultado);
          
        
    }
}

/* Questão 5*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        float altparede1, largparede1, altparede2, largparede2, alturajanela, alturaporta, alturatijolo, larguratijolo, largurajanela,larguraporta;
        
        Console.WriteLine ("Digite a altura da parede 1: ");
        altparede1 = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a largura da parede 1: ");
        largparede1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite a altura da parede 2: ");
        altparede2 = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a largura da parede 2: ");
        largparede2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite a altura da janela: ");
        alturajanela = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a largura da janela: ");
        largurajanela = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite a altura da porta: ");
        alturaporta = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a largura da porta: ");
        larguraporta = float.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite a altura do tijolo: ");
        alturatijolo = float.Parse(Console.ReadLine());
        Console.WriteLine ("Digite a largura do tijolo: ");
        larguratijolo = float.Parse(Console.ReadLine());
        
        float m2parede1, m2parede2, m2porta, m2janela, m2tijolo;
        
        m2parede1 = (altparede1 * altparede2) * 2;
        m2parede2 = (altparede2 * altparede2) * 2;
        m2porta = (alturaporta * larguraporta) *2;
        m2janela = (alturajanela * largurajanela) *2;
        m2tijolo = (alturatijolo * larguratijolo) *2;
        
        float paredes = m2parede1 + m2parede2;
        float janelaeporta = m2janela + m2porta;
        
        float m2salatotal = paredes - janelaeporta;
        
        float resultado = m2salatotal / m2tijolo; 
        
        Console.WriteLine ("A quantidade de tijolos e: " + resultado);

/* Questão 6*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int diferencaanos, diferencameses, diferenadias, dia1, dia2, mes1, mes2, ano1, ano2;
        Console.WriteLine ("Digite o ano 1: ");
        ano1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o ano 2: ");
        ano2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o mes 1: ");
        mes1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o mes 2: ");
        mes2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o dia 1: ");
        dia1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o dia 2: ");
        dia2 = int.Parse(Console.ReadLine());
        
        diferencaanos = ano1 - ano2;
        diferencameses = ((12 * diferencaanos) + mes2 - mes1);
        diferencadias = ((360 * diferencaanos) 30 * diferencameses) + dia2 - dia1;
        
        Console.WriteLine("A diferença de anos é: " +diferencaanos);
        Console.WriteLine("A diferença de meses é: " +diferencameses);
        Console.WriteLine("A diferença de dias é: " +diferencadias);
                            
                                                                      /* Segunda Lista */
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

                                                                      /* Terceira Lista */
 /* Questão 6 */

using System;
class propriedade {
  static void Main() {
    
    int idade;
    
    Console.WriteLine("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());
    
    if ( idade >= 8 && idade <= 10 ){
        Console.WriteLine("Sua categoria e infantil B");
        }else if ( idade >= 11 && idade <= 13 ){
            Console.WriteLine("Sua categoria e juvenil A");
            }else if ( idade >= 14 && idade <= 17 ){
                 Console.WriteLine("Sua categoria e juvenil B");
                }else if ( idade >= 18){ 
                    Console.WriteLine("Sua categoria e senior");
                    }else{ 
                        Console.WriteLine("Voce neo se encixa em nenhuma das categorias");
                        }
    }
}
        
/* Questão 5 */
 
using System;
class propriedade {
  static void Main() {
    
    float valor_reais, libra = 0, euro = 0, dolar = 0;
    int numero;
    
    Console.WriteLine("Digite seu valor em reais que voce quer coverter: ");
    valor_reais = float.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite 1 para Dolar, 2 para Libra e 3 para Euro : ");
    numero = int.Parse(Console.ReadLine());
    
    /*if ( numero == 1 ){
        dolar = valor_reais * 4.00;
        Console.WriteLine("O valor da conversao e: " + dolar );
            }else if ( numero == 2 ){
                libra = valor_reais * 6.15;
                Console.WriteLine("O valor da conversao e: " + libra );
                    }else{ 
                        euro = valor_reais * 4.72;
                        Console.WriteLine("O valor da conversao e: " + euro );
                        }*/
                        
    switch ( numero ){
    case 1:
        dolar = valor_reais * 4.00f;
        Console.WriteLine("O valor da conversao e: " + dolar );
        break;
    case 2:
        libra = valor_reais * 6.15f;
        Console.WriteLine("O valor da conversao e: " + libra );
        break;
    case 3:
        euro = valor_reais * 4.72f;
        Console.WriteLine("O valor da conversao e: " + euro );
        break;
        }
    }
}

/* Questão 9 */
        
using System;
class notas {
  static void Main() {
    
    int dinheiro, nota1 = 0, nota2 = 0, nota5 = 0, nota10 = 0, nota20 = 0 , nota50 = 0, nota100 = 0;
    
    Console.WriteLine("Digite seu dinheiro total : ");
    dinheiro = int.Parse(Console.ReadLine());
    
    if (dinheiro >= 100){
        nota100 = dinheiro / 100;
        nota50 = (dinheiro % 100) / 50;
        nota20 = ((dinheiro % 100) % 50) / 20;
        nota10 = (((dinheiro % 100) % 50) % 20) / 10;
        nota5 = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
    }else if (dinheiro >= 50 && dinheiro < 100){
        nota50 = dinheiro / 50;
        nota20 = ((dinheiro % 100) % 50) / 20;
        nota10 = (((dinheiro % 100) % 50) % 20) / 10;
        nota5 = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
    }else if (dinheiro >= 20 && dinheiro < 50){
        nota20 = dinheiro / 20;
        nota10 = (((dinheiro % 100) % 50) % 20) / 10;
        nota5 = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
    }else if (dinheiro >= 10 && dinheiro < 20){
        nota10 = dinheiro / 10;
        nota5 = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
    }else if (dinheiro >= 5 && dinheiro < 10){
        nota5 = dinheiro / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
    }else if (dinheiro >= 2 && dinheiro < 5){
        nota2 = dinheiro / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
    }else{ 
        nota1 = dinheiro / 1;
    }
    
    Console.WriteLine("Notas de 100 : " + nota100);
    Console.WriteLine("Notas de 50 : " + nota50);
    Console.WriteLine("Notas de 20 : " + nota20);
    Console.WriteLine("Notas de 10 : " + nota10);
    Console.WriteLine("Notas de 5 : "+ nota5);
    Console.WriteLine("Notas de 2 : " + nota2);
    Console.WriteLine("Moedas de 1 : " + nota1);
    }
}
        
        
        
        
