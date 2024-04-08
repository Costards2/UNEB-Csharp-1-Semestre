 /* Terceira Lista */
        
/* Questão 1 */
        
using System;
class 3025 {
  static void Main() {
    int numero, n1, n2, soma, produto;
    //entrada de dados
    Console.WriteLine("Escreva um numero entre 1000 e 9999");
    numero = int.Parse(Console.ReadLine());
    
    //operações
    n1 = numero/100;
    n2 = numero%100;
    soma = n1 + n2;
    produto = soma * soma;
  
    //saida
    if (produto == numero) {
        Console.WriteLine("Esse numero possui a mesma propriedade que o 3025");
    }
    else{
        Console.WriteLine("Esse numero não possui a mesma propriedade que o 3025");
    }    
  }
}
        
/* Questão 2 */
using System;
class ordem_ascendente {
static void Main() {
int numero1, numero2;

 if (numero1 < numero2) { Console.WriteLine($"{numero1}, {numero2}");
} else{
Console.WriteLine($"{numero2}, {numero1}"); }
} }

/* Questão 3 */
using System;
class par_ou_impar {
static void Main() {

int numero;

if ((numero%2 == 0)) {
Console.WriteLine($"o numero {numero} é par"); }
else{
Console.WriteLine($"o numero {numero} é impar");
} }
}

/*Questão 4 */
    
using System; 
  class maior {
    static void Main() {

int numero1, numero2, numero3; 
if (numero1 > numero2 & numero1 > numero3) {
Console.WriteLine($"{numero1}"); }
else{

 if (numero2 > numero1 & numero2 > numero3) { Console.WriteLine($"{numero2}");
}
else{
Console.WriteLine($"{numero3}"); }
} }
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
        
/* Questão 7 */ 

 using System; 
  class opcao {
    static void Main() {

int opcao, num1, num2, num3;
Console.WriteLine("escolha entre o numero 1, 2 ou 3"); 
opcao = int.Parse(Console.ReadLine()); 
     
Console.WriteLine("escreva um numero inteiro"); 
num1 = int.Parse(Console.ReadLine()); 
     
Console.WriteLine("escreva um numero inteiro"); 
num2 = int.Parse(Console.ReadLine()); 
  
Console.WriteLine("escreva um numero inteiro"); 
num3 = int.Parse(Console.ReadLine());
     
switch (opcao) { 
  
case 1:
Console.WriteLine($"A opção desejada foi: {num1}"); break;

case 2:
Console.WriteLine($"A opção desejada foi: {num2}"); break;

case 3:
Console.WriteLine($"A opção desejada foi: {num3}"); break;

default:
Console.WriteLine($"A opção desejada não foi encontrada"); break;
} }
}

/* Questão 8 */

using System;
 class bolo_de_Dinheiro {
  static void Main() {
int nota1, nota5, nota10, nota50, nota100, total; 

Console.WriteLine("Quantas notas de um 1 tem no bolo?"); 
nota1 = int.Parse(Console.ReadLine()); 
   
Console.WriteLine("Quantas notas de 5 reais tem no bolo?"); 
nota5 = int.Parse(Console.ReadLine()); 
   
Console.WriteLine("Quantas notas de 10 reais tem no bolo?"); 
nota10 = int.Parse(Console.ReadLine()); 
   
Console.WriteLine("Quantas notas de 50 reais tem no bolo?"); 
nota50 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Quantas notas de 100 reais tem no bolo?"); 
nota100 = int.Parse(Console.ReadLine());
   
if ((nota1>=0) & (nota5>=0) & (nota10>=0) & (nota50>=0) & (nota100>0))
{ 
 total = nota1 + (nota5 * 5) + (nota10 * 10) + (nota50 * 50) + (nota100 * 100); 
 Console.WriteLine($"tem {total} reis no bolo");
}
else
{
if((nota1>=0) & (nota5>=0) & (nota10>=0) & (nota50>0))
{
total = nota1 + (nota5 * 5) + (nota10 * 10) + (nota50 * 50);
Console.WriteLine($"tem {total} reis no bolo"); 
}
else
{
if((nota1>=0) & (nota5>=0) &(nota10>0))
{
total = nota1 + (nota5 * 5) + (nota10 * 10); 
Console.WriteLine($"tem {total} reis no bolo");
}
else
{
if((nota1>=0) & (nota5>0))
{
total = nota1 + (nota5 * 5);
Console.WriteLine($"tem {total} reis no bolo"); 
}
else
{
Console.WriteLine($"tem {nota1} reis no bolo");
 
} } 
} }
} }

/* Questão 9 */
        
//Fiz essa quetão de forma mais complicada
using System; 
 class notas {
  static void Main() {
    
    int dinheiro, nota1 = 0, nota2 = 0, nota5 = 0, nota10 = 0, nota20 = 0 , nota50 = 0, nota100 = 0;
    
    Console.WriteLine("Digite seu dinheiro total : ");
    dinheiro = int.Parse(Console.ReadLine());
    
    if (dinheiro >= 100)
    {                                                
        //Para fazer essa questão vôce só precisava dessa parte do código :
        nota100 = dinheiro / 100;                                        
        nota50 = (dinheiro % 100) / 50;
        nota20 = ((dinheiro % 100) % 50) / 20;
        nota10 = (((dinheiro % 100) % 50) % 20) / 10;
        nota5 = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
        //Contudo eu fiz essa "complicação" para usar If e Else.
   }
   else if (dinheiro >= 50 && dinheiro < 100)
   {
        nota50 = dinheiro / 50;
        nota20 = ((dinheiro % 100) % 50) / 20;
        nota10 = (((dinheiro % 100) % 50) % 20) / 10;
        nota5 = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
   }
   else if (dinheiro >= 20 && dinheiro < 50)
   {
        nota20 = dinheiro / 20;
        nota10 = (((dinheiro % 100) % 50) % 20) / 10;
        nota5 = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1; 
   }
   else if (dinheiro >= 10 && dinheiro < 20)
   {
        nota10 = dinheiro / 10;
        nota5 = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
    
   }
   else if (dinheiro >= 5 && dinheiro < 10)
   {
        nota5 = dinheiro / 5;
        nota2 = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
   }
   else if (dinheiro >= 2 && dinheiro < 5)
   {
        nota2 = dinheiro / 2;
        nota1 =((((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2) / 1;
   }
   else
   { 
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
 
/* Questão 10 */

using System; 
 class HelloWorld {
   static void Main() {
    int pista, carro1, carro2, velocidade1, velocidade2;
    Console.WriteLine("Informe o tamanho da pista em metros");
    pista = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a quantidade de segundos que o\nprimeiro carro demorou para
    completar o percurso");
    carro1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a quantidade de segundos que o \nsegundo carro demorou
    para completar o percurso");
    carro2 = int.Parse(Console.ReadLine());
    velocidade1 = pista/carro1; velocidade2 = pista/carro2;
       
    if (velocidade1 > velocidade2){
        Console.WriteLine($"O primeiro carro é mais rápido, chegando a velocidade de
            {velocidade1}m/s"); }else{
    
    Console.WriteLine($"O segundo carro é mais rápido, chegando a velocidade de {velocidade2}m/s");
} }
}
