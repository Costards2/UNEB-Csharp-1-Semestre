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
        ano1 = int.Parse(Console.Readline());
        
        Console.WriteLine ("Digite o ano 2: ");
        ano2 = int.Parse(Console.Readline());
        
        Console.WriteLine ("Digite o mes 1: ");
        mes1 = int.Parse(Console.Readline());
        
        Console.WriteLine ("Digite o mes 2: ");
        mes2 = int.Parse(Console.Readline());
        
        Console.WriteLine ("Digite o dia 1: ");
        dia1 = int.Parse(Console.Readline());
        
        Console.WriteLine ("Digite o dia 2: ");
        dia2 = int.Parse(Console.Readline());
        
        diferencaanos = ano1 - ano2;
        diferencameses = ((12 * diferencaanos) + mes2 - mes1);
        diferencadias = ((360 * diferencaanos) 30 * diferencameses) + dia2 - dia1;
        
        Console.WriteLine("A diferença de anos é: " +diferencaanos);
        Console.WriteLine("A diferença de meses é: " +diferencameses);
        Console.WriteLine("A diferença de dias é: " +diferencadias);

